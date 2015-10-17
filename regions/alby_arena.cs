//--- Aura Script -----------------------------------------------------------
// Alby Arena (29)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Alby Arena.
//---------------------------------------------------------------------------

public class AlbyArenaRegionScript : RegionScript
{
	public override void LoadWarps()
	{

	}

	public override void LoadSpawns()
	{	
		// Alby Arena (Group 51)
		CreateSpawner(race: 10401, amount: 1, region: 29, delay: 7200, delayMin: 10, delayMax: 10, coordinates: A(2102,2151, 2102,4196, 4321,4196, 4321,2151));  // Troll
	}
}


