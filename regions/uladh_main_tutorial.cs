//--- Aura Script -----------------------------------------------------------
// Uladh main Tutorial (118) (Forest of Souls)
//--- Description -----------------------------------------------------------
// Tutorial Region for fighting Wolves and defending Sheep.
//---------------------------------------------------------------------------

public class UladhTutorialRegionScript : RegionScript
{
	public override void LoadWarps()
	{

	}

	public override void LoadSpawns()
	{
		// Central Plains (Group 297)
		CreateSpawner(race: 20025, amount: 10, region: 118, delay: 120, delayMin: 10, delayMax: 10, coordinates: A(57727,56911, 57720,58804, 64216,58830, 64224,56937));  // Gray Wolf Tutorial

		// Near Harbor(Group 296)
		CreateSpawner(race: 40006, amount: 20, region: 118, delay: 600, delayMin: 10, delayMax: 10, coordinates: A(57665,57117, 57658,59844, 64252,59862, 64259,57135));  // Sheep Tutorial

	}
}
