using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;
using Terraria.ModLoader.UI;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace PrismaPortraits.UI
{
    class PortraitUIState : UIState
    {
        private int NPCIndex;
        private static Texture2D PortraitWindow = Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Window", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value;
        private static Texture2D PortraitImage = Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Angler_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value;

        private UIPanel backPanel = new UIPanel();
        private UIPanel imagePanel = new UIPanel();
        public PortraitUIState(int npcI)
        {
            NPCIndex = npcI;
        }

        public void SetNPCIndex(int newIndex) => NPCIndex = newIndex;

        private UIText header;

        public override void OnInitialize()
        {

            backPanel.Width.Set(112, 0f);
            backPanel.Height.Set(112, 0f);
            backPanel.Left.Set(-365, 0.5f);
            backPanel.Top.Set(105, 0f);
            backPanel.BackgroundColor = Color.Transparent;
            backPanel.BorderColor = Color.Transparent;

            header = new UIText("Bbbbbbb", 0.85f);
            header.HAlign = 0.5f;
            header.Top.Set(0, 1.05f);

            imagePanel.Width.Set(200, 0f);
            imagePanel.Height.Set(200, 0f);
            imagePanel.Left.Set(-409, 0.5f);
            imagePanel.Top.Set(61, 0f);
            imagePanel.BackgroundColor = Color.Transparent;
            imagePanel.BorderColor = Color.Transparent;

            backPanel.Append(header);

            Append(backPanel);
            Append(imagePanel);
        }

        public override void OnActivate()
        {
            backPanel.RemoveAllChildren();
            backPanel.Append(header);
            GetImage();
            
            if (Main.npc.IndexInRange(NPCIndex) || Main.npc[NPCIndex].active) header.SetText(Main.npc[NPCIndex].GivenName);
        }
        private void GetImage()
        {
            string variant = "";
            if (Main.npc[NPCIndex].IsShimmerVariant == true) variant = "shimmer";
            if (Main.npc[NPCIndex].type == NPCID.BestiaryGirl && Main.moonPhase == 0 && !Main.dayTime) variant += "fullmoon";
            else if (Main.npc[NPCIndex].type == NPCID.TownBunny)
            {
                int headType = TownNPCProfiles.GetHeadIndexSafe(Main.npc[NPCIndex]);
                if (headType == NPCHeadID.BunnyAngora) variant = "Angora";
                else if (headType == NPCHeadID.BunnyDutch) variant = "Dutch";
                else if(headType == NPCHeadID.BunnyFlemish) variant = "Flemish";
                else if(headType == NPCHeadID.BunnyLop) variant = "Lop";
                else if(headType == NPCHeadID.BunnySilver) variant = "Silver";
                else if(headType == NPCHeadID.BunnyWhite) variant = "White";
            }
            else if (Main.npc[NPCIndex].type == NPCID.TownCat)
            {
                int headType = TownNPCProfiles.GetHeadIndexSafe(Main.npc[NPCIndex]);
                if (headType == NPCHeadID.CatBlack) variant = "Black";
                else if (headType == NPCHeadID.CatOrangeTabby) variant = "Orangetabby";
                else if(headType == NPCHeadID.CatRussianBlue) variant = "RussianBlue";
                else if(headType == NPCHeadID.CatSiamese) variant = "Siamese";
                else if(headType == NPCHeadID.CatSilver) variant = "Silver";
                else if(headType == NPCHeadID.CatWhite) variant = "White";
            }
            else if (Main.npc[NPCIndex].type == NPCID.TownDog)
            {
                int headType = TownNPCProfiles.GetHeadIndexSafe(Main.npc[NPCIndex]);
                if (headType == NPCHeadID.DogBeagle) variant = "Beagle";
                else if (headType == NPCHeadID.DogCorgi) variant = "Corgi";
                else if(headType == NPCHeadID.DogDalmation) variant = "Dalmatian";
                else if(headType == NPCHeadID.DogHusky) variant = "Husky";
                else if(headType == NPCHeadID.DogLabrador) variant = "Labrador";
                else if(headType == NPCHeadID.DogPitBull) variant = "PitBull";
            }
            KeyValuePair<int, string> key = new KeyValuePair<int, string>(Main.npc[NPCIndex].type, variant);
            if(PrismaPortraits.Portraits.ContainsKey(key))
            {
                PortraitImage = PrismaPortraits.Portraits[key];
            }
        }
        public bool InRangeOfNPC()
        {
            if (!Main.npc.IndexInRange(NPCIndex) || !Main.npc[NPCIndex].active) return false;

            Rectangle validTalkArea = Utils.CenteredRectangle(Main.LocalPlayer.Center, new Vector2(Player.tileRangeX * 16f * 3f, Player.tileRangeY * 16f * 3f));
            return validTalkArea.Intersects(Main.npc[NPCIndex].Hitbox);
        }

        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PortraitWindow, new Rectangle((int)backPanel.GetDimensions().X, (int)backPanel.GetDimensions().Y, (int)backPanel.GetDimensions().Width, (int)backPanel.GetDimensions().Height), Color.White);
            spriteBatch.Draw(PortraitImage, new Rectangle((int)imagePanel.GetDimensions().X, (int)imagePanel.GetDimensions().Y, (int)imagePanel.GetDimensions().Width, (int)imagePanel.GetDimensions().Height), Color.White);

            if (Main.LocalPlayer.chest != -1 || Main.LocalPlayer.sign != -1 || !InRangeOfNPC() || Main.LocalPlayer.TalkNPC != Main.npc[NPCIndex] || Main.playerInventory || Main.InGuideCraftMenu)
                GetInstance<PortraitUISystem>().HideUI(Main.myPlayer);

            base.DrawSelf(spriteBatch);
        }

    }
    
}
