using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace PrismaPortraits
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class PrismaPortraits : Mod
	{
		internal static Dictionary<KeyValuePair<int, string>, Texture2D> Portraits = new Dictionary<KeyValuePair<int, string>, Texture2D>();


        public override void PostSetupContent()
        {
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Angler, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Angler", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Angler, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Angler_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.ArmsDealer, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_ArmsDealer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.ArmsDealer, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_ArmsDealer_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Clothier, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Clothier", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Clothier, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Clothier_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Cyborg, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cyborg", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Cyborg, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cyborg_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Demolitionist, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Demolitionist", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Demolitionist, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Demolitionist_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Dryad, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dryad", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Dryad, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dryad_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.DyeTrader, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_DyeTrader", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.DyeTrader, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_DyeTrader_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.GoblinTinkerer, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_GoblinTinkerer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.GoblinTinkerer, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_GoblinTinkerer_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Golfer, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Golfer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Golfer, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Golfer_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Guide, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Guide", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Guide, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Guide_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Mechanic, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Mechanic", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Mechanic, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Mechanic_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Merchant, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Merchant", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Merchant, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Merchant_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Nurse, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Nurse", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Nurse, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Nurse_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.OldMan, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_OldMan", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.OldMan, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_OldMan_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Painter, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Painter", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Painter, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Painter_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.PartyGirl, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_PartyGirl", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.PartyGirl, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_PartyGirl_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Pirate, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Pirate", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Pirate, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Pirate_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Princess, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Princess", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Princess, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Princess_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.SantaClaus, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Santa", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.SantaClaus, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Santa_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.SkeletonMerchant, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SkeletonMerchant", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.SkeletonMerchant, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SkeletonMerchant_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Steampunker, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Steampunker", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Steampunker, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Steampunker_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Stylist, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Stylist", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Stylist, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Stylist_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.DD2Bartender, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Tavernkeep", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.DD2Bartender, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Tavernkeep_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.TaxCollector, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_TaxCollector", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TaxCollector, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_TaxCollector_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.TravellingMerchant, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_TravellingMerchant", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TravellingMerchant, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_TravellingMerchant_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Truffle, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Truffle", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Truffle, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Truffle_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.WitchDoctor, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_WitchDoctor", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.WitchDoctor, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_WitchDoctor_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.Wizard, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Wizard", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.Wizard, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Wizard_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.BestiaryGirl, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Zoologista", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.BestiaryGirl, "shimmer"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Zoologista_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.BestiaryGirl, "fullmoon"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Zoologistb", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.BestiaryGirl, "shimmerfullmoon"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Zoologistb_shimmer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimePurple, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeClumsy", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeGreen, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeCool", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeRainbow, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeDiva", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeOld, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeElder", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeYellow, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeMystic", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeBlue, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeNerdy", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeCopper, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeSquire", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownSlimeRed, ""), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_SlimeSurly", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownBunny, "White"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Bunny_White", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownBunny, "Angora"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Bunny_Angora", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownBunny, "Dutch"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Bunny_Dutch", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownBunny, "Flemish"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Bunny_Flemish", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownBunny, "Lop"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Bunny_Lop", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownBunny, "Silver"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Bunny_Silver", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownCat, "Siamese"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cat_Siamese", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownCat, "Black"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cat_Black", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownCat, "Orangetabby"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cat_Orangetabby", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownCat, "RussianBlue"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cat_RussianBlue", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownCat, "Silver"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cat_Silver", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownCat, "White"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Cat_White", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownDog, "Labrador"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dog_Labrador", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownDog, "PitBull"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dog_PitBull", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownDog, "Beagle"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dog_Beagle", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownDog, "Corgi"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dog_Corgi", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownDog, "Dalmatian"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dog_Dalmatian", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
			Portraits.Add(new KeyValuePair<int, string>(NPCID.TownDog, "Husky"), Request<Texture2D>("PrismaPortraits/Portraits/Portrait_Dog_Husky", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);

        }

        public override void Unload()
        {
            Portraits = null;
        }

        public override object Call(params object[] args)
        {
            if (ModContent.GetInstance<PrismaPortraits>() == null)
            {
                Logger.Error("Instance error.");
                return "Error";
            }
            string message = (string)args[0];
            if (message == "AddPortrait")
            {
				if (args.Length != 4) return "Wrong amount of arguments";
				int npcid = (int)args[1];
				bool shimmer = (bool)args[2];
				string texturePath = (string)args[3];
				Portraits.Add(new KeyValuePair<int, string>(npcid, shimmer ? "shimmer" : ""), Request<Texture2D>(texturePath, ReLogic.Content.AssetRequestMode.ImmediateLoad).Value);
                return "Success";
            }
            return "Error";
        }
    }
}
