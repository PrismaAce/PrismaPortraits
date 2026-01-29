using PrismaPortraits.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrismaPortraits
{
    public class PortraitGlobalNPC : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            string variant = "";
            if (npc.IsShimmerVariant == true) variant = "shimmer";
            if (npc.type == NPCID.BestiaryGirl && Main.moonPhase == 0 && !Main.dayTime) variant += "fullmoon";
            else if (npc.type == NPCID.TownBunny)
            {
                int headType = TownNPCProfiles.GetHeadIndexSafe(npc);
                if (headType == NPCHeadID.BunnyAngora) variant = "Angora";
                else if (headType == NPCHeadID.BunnyDutch) variant = "Dutch";
                else if (headType == NPCHeadID.BunnyFlemish) variant = "Flemish";
                else if (headType == NPCHeadID.BunnyLop) variant = "Lop";
                else if (headType == NPCHeadID.BunnySilver) variant = "Silver";
                else if (headType == NPCHeadID.BunnyWhite) variant = "White";
            }
            else if (npc.type == NPCID.TownCat)
            {
                int headType = TownNPCProfiles.GetHeadIndexSafe(npc);
                if (headType == NPCHeadID.CatBlack) variant = "Black";
                else if (headType == NPCHeadID.CatOrangeTabby) variant = "Orangetabby";
                else if (headType == NPCHeadID.CatRussianBlue) variant = "RussianBlue";
                else if (headType == NPCHeadID.CatSiamese) variant = "Siamese";
                else if (headType == NPCHeadID.CatSilver) variant = "Silver";
                else if (headType == NPCHeadID.CatWhite) variant = "White";
            }
            else if (npc.type == NPCID.TownDog)
            {
                int headType = TownNPCProfiles.GetHeadIndexSafe(npc);
                if (headType == NPCHeadID.DogBeagle) variant = "Beagle";
                else if (headType == NPCHeadID.DogCorgi) variant = "Corgi";
                else if (headType == NPCHeadID.DogDalmation) variant = "Dalmatian";
                else if (headType == NPCHeadID.DogHusky) variant = "Husky";
                else if (headType == NPCHeadID.DogLabrador) variant = "Labrador";
                else if (headType == NPCHeadID.DogPitBull) variant = "PitBull";
            }

            KeyValuePair<int, string> key = new KeyValuePair<int, string>(npc.type, variant);
            if (PrismaPortraits.Portraits.ContainsKey(key))
            {
                ModContent.GetInstance<PortraitUISystem>().ShowUI(npc.whoAmI, Main.myPlayer);
            }
            
        }
    }
}
