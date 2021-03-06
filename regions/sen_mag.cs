//--- Aura Script -----------------------------------------------------------
// Sen Mag (53)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Sen Mag.
// Region between Emain and Gairech.
//---------------------------------------------------------------------------

public class SenMagRegionScript : RegionScript
{
	public override void LoadProperties()
	{
		SetProperty(53, "GuildStonesDisabled", true);
		SetProperty(53, "PvpDisabled", true);
	}

	public override void LoadWarps()
	{
		// Peaca
		SetPropBehavior(0x00A0003500070017, PropWarp(53,75599,118213, 74,3215,2114));
		SetPropBehavior(0x00A0004A00000011, PropWarp(74,3191,1710, 53,75606,117454));

		// Sen Mag Residential 00A00035000500CB
		SetPropBehavior(0x00A00035000500CB, PropWarp(53,103137,78391, 202,54574,57302));
		SetPropBehavior(0x00A000CA00030208, PropWarp(202,54835,57658, 53,103137,78391));

		// Gairech - Sen Mag
		//SetPropBehavior(0x00A0003500030005, PropWarp(53,138468,121883, 30,9098,72464));
		SetPropBehavior(0x00A0001E00050060, PropWarp(30,9098,72464, 53,138468,121883));

	}
	
	public override void LoadSpawns()
	{
		// North-West Top (Group 130)
		CreateSpawner(race: 70001, amount: 10, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(82798,116691, 82798,122305, 100289,122305, 100289,116691));  // Brown Bear
		CreateSpawner(race: 70004, amount: 4, region: 53, delay: 360, delayMin: 10, delayMax: 10, coordinates: A(82798,116691, 82798,122305, 100289,122305, 100289,116691));  // Brown Grizzly Bear
		CreateSpawner(race: 70006, amount: 2, region: 53, delay: 420, delayMin: 10, delayMax: 10, coordinates: A(82798,116691, 82798,122305, 100289,122305, 100289,116691));  // Black Grizzly Bear

		// North-West Bottom (Group 132)
		CreateSpawner(race: 70001, amount: 4, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(76220,104675, 76220,107624, 89937,107624, 89937,104675));  // Brown Bear
		CreateSpawner(race: 70002, amount: 10, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(76220,104675, 76220,107624, 89937,107624, 89937,104675));  // Red Bear
		CreateSpawner(race: 70004, amount: 2, region: 53, delay: 360, delayMin: 10, delayMax: 10, coordinates: A(76220,104675, 76220,107624, 89937,107624, 89937,104675));  // Brown Grizzly Bear

		// Residential Road, North-West (Group 133)
		CreateSpawner(race: 70002, amount: 10, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(92153,99023, 92153,104453, 101863,104453, 101863,99023));  // Red Bear
		CreateSpawner(race: 70004, amount: 4, region: 53, delay: 360, delayMin: 10, delayMax: 10, coordinates: A(92153,99023, 92153,104453, 101863,104453, 101863,99023));  // Brown Grizzly Bear
		CreateSpawner(race: 70006, amount: 3, region: 53, delay: 420, delayMin: 10, delayMax: 10, coordinates: A(92153,99023, 92153,104453, 101863,104453, 101863,99023));  // Black Grizzly Bear

		// Residential Road, South-West (Group 134)
		CreateSpawner(race: 70001, amount: 10, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(93678,83904, 93678,91790, 98738,91790, 98738,83904));  // Brown Bear
		CreateSpawner(race: 70001, amount: 4, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(93678,83904, 93678,91790, 98738,91790, 98738,83904));  // Brown Bear *
		CreateSpawner(race: 70004, amount: 4, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(93678,83904, 93678,91790, 98738,91790, 98738,83904));  // Brown Grizzly Bear

		// Residential Road, North-East (Group 136)
		CreateSpawner(race: 70001, amount: 10, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(104822,96821, 104822,102408, 110897,102408, 110897,96821));  // Brown Bear
		CreateSpawner(race: 70004, amount: 4, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(104822,96821, 104822,102408, 110897,102408, 110897,96821));  // Brown Grizzly Bear

		// Residential Road, South-East (Group 137)
		CreateSpawner(race: 70004, amount: 4, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(106633,83725, 109397,95716, 113417,94789, 110654,82798));  // Brown Grizzly Bear
		CreateSpawner(race: 70006, amount: 2, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(106633,83725, 109397,95716, 113417,94789, 110654,82798));  // Black Grizzly Bear
		CreateSpawner(race: 70007, amount: 4, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(106633,83725, 109397,95716, 113417,94789, 110654,82798));  // Brown Grizzly Bear Cub
		CreateSpawner(race: 70009, amount: 2, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(106633,83725, 109397,95716, 113417,94789, 110654,82798));  // Black Grizzly Bear Cub

		// North-East Top (Group 131)
		CreateSpawner(race: 70001, amount: 10, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(110232,119034, 109860,124188, 124413,125239, 124785,120085));  // Brown Bear
		CreateSpawner(race: 70004, amount: 4, region: 53, delay: 360, delayMin: 10, delayMax: 10, coordinates: A(110232,119034, 109860,124188, 124413,125239, 124785,120085));  // Brown Grizzly Bear
		CreateSpawner(race: 70006, amount: 4, region: 53, delay: 420, delayMin: 10, delayMax: 10, coordinates: A(110232,119034, 109860,124188, 124413,125239, 124785,120085));  // Black Grizzly Bear

		// North-East Bottom (Group 135)
		CreateSpawner(race: 70004, amount: 3, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(115894,106670, 115894,115027, 123557,115027, 123557,106670));  // Brown Grizzly Bear
		CreateSpawner(race: 70006, amount: 3, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(115894,106670, 115894,115027, 123557,115027, 123557,106670));  // Black Grizzly Bear
		CreateSpawner(race: 70007, amount: 3, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(115894,106670, 115894,115027, 123557,115027, 123557,106670));  // Brown Grizzly Bear Cub
		CreateSpawner(race: 70009, amount: 3, region: 53, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(115894,106670, 115894,115027, 123557,115027, 123557,106670));  // Black Grizzly Bear Cub

		//BOSS: White Grizzly Bear 70017 with title 30002
		//Adds: 2x Black Grizzly Cub 70009 with title 30001 and 4x Black Grizzly Bear 70006 with titles: 30001, 30004, 30005, 30007
	}
}
