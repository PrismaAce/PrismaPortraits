# PrismaPortraits
Scuffed implementation of 1.4.5 portrait system with mod support

# Mod Call
"AddPortrait", int npcID, bool shimmer, string texturePath

Ex:
portraitMod.Call("AddPortrait", NPCType<Content.NPCs.Town.CombatExpert.CombatExpert>(), false, "PrismaAlchemy/Portraits/Portrait_CombatExpert");
portraitMod.Call("AddPortrait", NPCType<Content.NPCs.Town.CombatExpert.CombatExpert>(), true, "PrismaAlchemy/Portraits/Portrait_CombatExpert_shimmer");
