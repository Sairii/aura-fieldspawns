//--- Aura Script -----------------------------------------------------------
// Sliab Cuilin (301)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Sliab Cuilin.
//---------------------------------------------------------------------------

public class SliabCuilinRegionScript : RegionScript
{
	public override void LoadWarps()
	{
		// Dugald Aisle - Sliab Cuilin
		SetPropBehavior(0x00A00010000C00D2, PropWarp(16,4483,62807, 301,121320,91323));
		SetPropBehavior(0x00A0012D00070032, PropWarp(301,121320,91323, 16,4483,62807));

	}

	public override void LoadSpawns()
	{
		// West near Taillteann Warp (Group 1700)
		CreateSpawner(race: 50002, amount: 3, region: 301, coordinates: A(63546,97121, 72105,97364, 72155,95627, 63595,95384));  // Red Fox
		CreateSpawner(race: 50005, amount: 5, region: 301, coordinates: A(63546,97121, 72105,97364, 72155,95627, 63595,95384));  // Young Red Fox
		
		// South West (Group 1701) // Coords reach outside the map?? devcat please! Appears to be not in use
		//CreateSpawner(race: 50002, amount: 5, region: 301, coordinates: A(70398,86706, 70398,95224, 77640,95224, 77640,86706));  // Red Fox
		//CreateSpawner(race: 50005, amount: 5, region: 301, coordinates: A(70398,86706, 70398,95224, 77640,95224, 77640,86706));  // Young Red Fox

		// Center - North (Group 1702)
		CreateSpawner(race: 50003, amount: 3, region: 301, coordinates: A(76973,93239, 76973,101306, 84948,101306, 84948,93239));  // Gray Fox
		CreateSpawner(race: 50006, amount: 3, region: 301, coordinates: A(76973,93239, 76973,101306, 84948,101306, 84948,93239));  // Young Gray Fox

		// Center (Group 1703)
		CreateSpawner(race: 70005, amount: 1, region: 301, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(81732,89327, 81732,91510, 84458,91510, 84458,89327));  // Red Grizzly Bear
		CreateSpawner(race: 70008, amount: 3, region: 301, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(81732,89327, 81732,91510, 84458,91510, 84458,89327));  // Red Grizzly Cub

		// Quarry (Group 1704)
		CreateSpawner(race: 50101, amount: 3, region: 301, coordinates: A(77095,82060, 77095,86713, 84119,86713, 84119,82060));  // Raccoon
		CreateSpawner(race: 50102, amount: 5, region: 301, coordinates: A(77095,82060, 77095,86713, 84119,86713, 84119,82060));  // Young Raccoon

		// South Moongate (Group 1705)
		CreateSpawner(race: 40118, amount: 5, region: 301, delay: 200, delayMin: 10, delayMax: 10, coordinates: A(87292,81865, 87292,88937, 93135,88937, 93135,81865));  // Plateau Wild Boar
		CreateSpawner(race: 50001, amount: 3, region: 301, coordinates: A(87292,81865, 87292,88937, 93135,88937, 93135,81865));  // Brown Fox
		CreateSpawner(race: 50007, amount: 5, region: 301, coordinates: A(87292,81865, 87292,88937, 93135,88937, 93135,81865));  // Young Brown Fox

		// Center - East (Group 1706)
		CreateSpawner(race: 50102, amount: 5, region: 301, coordinates: A(87660,90858, 87660,92297, 95895,92297, 95895,90858));  // Young Raccoon

		// East (Group 1707)
		CreateSpawner(race: 40118, amount: 15, region: 301, coordinates: A(93234,91365, 93234,96796, 102776,96796, 102776,91365));  // Plateau Wild Boar
		CreateSpawner(race: 50101, amount: 3, region: 301, coordinates: A(93234,91365, 93234,96796, 102776,96796, 102776,91365));  // Raccoon

		// East near Warp (Group 1708)
		CreateSpawner(race: 40118, amount: 5, region: 301, delay: 200, delayMin: 10, delayMax: 10, coordinates: A(103191,90833, 103191,93918, 106922,93918, 106922,90833));  // Plateau Wild Boar
		CreateSpawner(race: 50101, amount: 3, region: 301, coordinates: A(103191,90833, 103191,93918, 106922,93918, 106922,90833));  // Raccoon
		CreateSpawner(race: 50102, amount: 2, region: 301, coordinates: A(103191,90833, 103191,93918, 106922,93918, 106922,90833));  // Young Raccoon

	}
}


