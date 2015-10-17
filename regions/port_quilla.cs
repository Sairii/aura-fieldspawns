//--- Aura Script -----------------------------------------------------------
// Port Quilla Iria (101)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Port Quilla Iria.
//---------------------------------------------------------------------------

public class PortQuillaRegionScript : RegionScript
{
	public override void LoadWarps()
	{
		// Port Quilla - Quilla Base Camp
		SetPropBehavior(0x00A0006500020126, PropWarp(101,68689,96445, 3001,164080,168450));
		SetPropBehavior(0x00A00BB9001600C3, PropWarp(3001,164080,168450, 101,68689,96445));
	}

	public override void LoadSpawns()
	{
	}
}


