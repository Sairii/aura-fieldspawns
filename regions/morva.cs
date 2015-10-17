//--- Aura Script -----------------------------------------------------------
// Morva Aisle (96)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Morva Aisle.
//---------------------------------------------------------------------------

public class MorvaAisleRegionScript : RegionScript
{
	public override void LoadWarps()
	{
		// Port Ceann - Morva Aisle 
		SetPropBehavior(0x00A0006400000041, PropWarp(100,43275,53483, 96,18420,5117));
		SetPropBehavior(0x00A000600008000D, PropWarp(96,18420,5117, 100,43275,53483));

		// Sen Mag Residential - Morva Aisle 
		SetPropBehavior(0x00A000CA000501B9, PropWarp(202,55634,35881, 96,2963,24018));
		SetPropBehavior(0x00A0006000070018, PropWarp(96,2963,24018, 202,55634,35881));
	}

	public override void LoadSpawns()
	{
		// Central Plains (Group 290)
		CreateSpawner(race: 20001, amount: 6, region: 96, delay: 60, delayMin: 10, delayMax: 10, coordinates: A(21133,27174, 21916,23465, 20674,23203, 19891,26912));  // Gray Wolf

		// Near Harbor(Group 292)
		CreateSpawner(race: 50002, amount: 4, region: 96, delay: 60, delayMin: 10, delayMax: 10, coordinates: A(21103,17936, 20994,14146, 19725,14183, 19834,17973));  // Red Fox

		// Near Harbor(Group 291)
		CreateSpawner(race: 50002, amount: 4, region: 96, delay: 60, delayMin: 10, delayMax: 10, coordinates: A(17313,12715, 17492,8928, 16224,8868, 16045,12655));  // Red Fox
	}
}


