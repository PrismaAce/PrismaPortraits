using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;

namespace PrismaPortraits.UI
{
    class PortraitUISystem : ModSystem
    {
        public Dictionary<int, UserInterface> UserInterfaces;
        public Dictionary<int, PortraitUIState> PortraitUIs;
        public List<int> OpenUIs;

        public override void Load()
        {
            if (!Main.dedServ)
            {
                UserInterfaces = new Dictionary<int, UserInterface>();
                PortraitUIs = new Dictionary<int, PortraitUIState>();
                OpenUIs = new List<int>();
            }
        }

        public override void Unload()
        {
            UserInterfaces.Clear();
            PortraitUIs.Clear();
            OpenUIs.Clear();
        }

        private GameTime _lastUpdateUiGameTime;

        public override void UpdateUI(GameTime gameTime)
        {
            _lastUpdateUiGameTime = gameTime;
            foreach (var ui in UserInterfaces.Values)
            {
                if (ui?.CurrentState != null)
                {
                    ui.Update(gameTime);
                }
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "PrismaAclchemy: ShopSwitchInterface",
                    delegate
                    {
                        // Draw the UI for all active tile UIs
                        foreach (var ui in UserInterfaces.Values)
                        {
                            if (_lastUpdateUiGameTime != null && ui?.CurrentState != null)
                            {
                                ui.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                            }
                        }
                        return true;
                    },
                    InterfaceScaleType.UI));
            }
        }

        public void ShowUI(int whoAmI, int playerID)
        {
            HideUI(playerID);
            if (!UserInterfaces.ContainsKey(playerID))
            {
                // Create new UI instance for this tile if it doesn't exist
                var newUI = new UserInterface();
                var newBoxUI = new PortraitUIState(whoAmI); 
                newBoxUI.Activate();
                UserInterfaces[playerID] = newUI;
                PortraitUIs[playerID] = newBoxUI;
            }
            PortraitUIs[playerID].SetNPCIndex(whoAmI);
            UserInterfaces[playerID].SetState(PortraitUIs[playerID]);
            OpenUIs.Add(playerID);
        }

        public void HideUI(int playerID)
        {
            if (UserInterfaces.ContainsKey(playerID))
            {
                UserInterfaces[playerID].SetState(null);
            }
            OpenUIs.Remove(playerID);
        }
    }
}
