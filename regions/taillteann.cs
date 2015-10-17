//--- Aura Script -----------------------------------------------------------
// Taillteann (300)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Taillteann.
//---------------------------------------------------------------------------

public class TaillteannRegionScript : RegionScript
{
	public override void LoadWarps()
	{
		// Sliab Cuilin - Taillteann
		SetPropBehavior(0x00A0012C002D005C, PropWarp(300,265194,180566, 301,61941,96907));
		SetPropBehavior(0x00A0012D000100E2, PropWarp(301,61941,96907, 300,265194,180566));

	}

	public override void LoadSpawns()
	{
		// West path to Corrib (Group 1736)
		CreateSpawner(race: 40118, amount: 15, region: 300, delay: 200, delayMin: 10, delayMax: 10, coordinates: A(143716,185185, 134997,190755, 140733,199735, 149452,194165));  // Plateau Wild Boar
		CreateSpawner(race: 70801, amount: 10, region: 300, delay: 200, delayMin: 10, delayMax: 10, titles: A(30020, 0, 0), coordinates: A(143716,185185, 134997,190755, 140733,199735, 149452,194165));  // Burgundy Bear
		CreateSpawner(race: 70801, amount: 5, region: 300, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(143716,185185, 134997,190755, 140733,199735, 149452,194165));  // Burgundy Bear

		// South of West Beacon Mound (Group 1737)
		CreateSpawner(race: 40118, amount: 15, region: 300, delay: 200, delayMin: 10, delayMax: 10, coordinates: A(164851,192430, 177836,192449, 177843,187173, 164858,187155));  // Plateau Wild Boar
		CreateSpawner(race: 50101, amount: 3, region: 300, coordinates: A(164851,192430, 177836,192449, 177843,187173, 164858,187155));  // Raccoon
		CreateSpawner(race: 50102, amount: 1, region: 300, coordinates: A(164851,192430, 177836,192449, 177843,187173, 164858,187155));  // Young Raccoon

		// Ontop West Beacon Mound (Group 1738)
		CreateSpawner(race: 50101, amount: 3, region: 300, coordinates: A(161915,198701, 161915,200897, 175573,200897, 175573,198701));  // Raccoon
		CreateSpawner(race: 50102, amount: 5, region: 300, coordinates: A(161915,198701, 161915,200897, 175573,200897, 175573,198701));  // Young Raccoon

		// North West (Group 1731)
		CreateSpawner(race: 20001, amount: 2, region: 300, coordinates: A(167807,212326, 167807,217908, 175413,217908, 175413,212326));  // Gray Wolf
		CreateSpawner(race: 20005, amount: 1, region: 300, coordinates: A(167807,212326, 167807,217908, 175413,217908, 175413,212326));  // Brown Dire Wolf
		CreateSpawner(race: 70002, amount: 2, region: 300, coordinates: A(167807,212326, 167807,217908, 175413,217908, 175413,212326));  // Red Bear
		CreateSpawner(race: 70801, amount: 5, region: 300, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(167807,212326, 167807,217908, 175413,217908, 175413,212326));  // Burgundy Bear

		// Ontop West Beacon Mound (Group 1732)
		CreateSpawner(race: 70002, amount: 2, region: 300, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(166003,205630, 166003,207851, 177598,207851, 177598,205630));  // Red Bear

		// West City Entrance (Group 1721)
		CreateSpawner(race: 50003, amount: 3, region: 300, coordinates: A(188713,194868, 188713,203493, 196229,203493, 196229,194868));  // Gray Fox
		CreateSpawner(race: 50006, amount: 3, region: 300, coordinates: A(188713,194868, 188713,203493, 196229,203493, 196229,194868));  // Young Gray Fox

		// South West of City Entrance (Group 1722)
		CreateSpawner(race: 20007, amount: 4, region: 300, coordinates: A(180810,180324, 180810,191221, 192049,191221, 192049,180324));  // Black Dire Wolf
		CreateSpawner(race: 20011, amount: 12, region: 300, delay: 150, delayMin: 5, delayMax: 5, coordinates: A(180810,180324, 180810,191221, 192049,191221, 192049,180324));  // Black Dire Wolf Cub

		// North West of City Entrance (Group 1733)
 		CreateSpawner(race: 20007, amount: 3, region: 300, coordinates: A(188182,210623, 181779,214055, 184835,219755, 191238,216323));  // Black Dire Wolf
		CreateSpawner(race: 20011, amount: 12, region: 300, delay: 150, delayMin: 5, delayMax: 5, coordinates: A(188182,210623, 181779,214055, 184835,219755, 191238,216323));  // Black Dire Wolf Cub

		// Near Druid House (Group 1734)
		CreateSpawner(race: 40011, amount: 3, region: 300, coordinates: A(191901,216106, 190634,217920, 199570,224158, 200837,222344));  // Taillteann Goat

		// South of Taillteann (Group 1717)
		CreateSpawner(race: 40011, amount: 10, region: 300, coordinates: A(219229,166117, 219229,174901, 227704,174901, 227704,166117));  // Taillteann Goat

		// South of Taillteann South of Goats (Group 1718)
		CreateSpawner(race: 20007, amount: 3, region: 300, coordinates: A(221248,155267, 221248,161690, 228332,161690, 228332,155267));  // Black Dire Wolf
		CreateSpawner(race: 20011, amount: 14, region: 300, delay: 150, delayMin: 5, delayMax: 5, coordinates: A(221248,155267, 221248,161690, 228332,161690, 228332,155267));  // Black Dire Wolf Cub

		// North of Taillteann (Group 1716)
		CreateSpawner(race: 40011, amount: 6, region: 300, coordinates: A(208352,213241, 208352,215672, 227068,215672, 227068,213241));  // Taillteann Goat

		// North East of Taillteann (Group 1719)
		CreateSpawner(race: 20007, amount: 4, region: 300, coordinates: A(243994,203263, 249103,203236, 249046,192537, 243938,192564));  // Black Dire Wolf
		CreateSpawner(race: 20011, amount: 12, region: 300, delay: 150, delayMin: 5, delayMax: 5, coordinates: A(243994,203263, 249103,203236, 249046,192537, 243938,192564));  // Black Dire Wolf Cub
		CreateSpawner(race: 40118, amount: 5, region: 300, delay: 200, delayMin: 10, delayMax: 10, coordinates: A(243994,203263, 249103,203236, 249046,192537, 243938,192564));  // Plateau Wild Boar	

		// Ontop East Beacon Mound (Group 1720)
		CreateSpawner(race: 50001, amount: 3, region: 300, coordinates: A(241952,180666, 247201,197972, 250943,196837, 245695,179530));  // Brown Fox
		CreateSpawner(race: 50007, amount: 5, region: 300, coordinates: A(241952,180666, 247201,197972, 250943,196837, 245695,179530));  // Young Brown Fox

		// Taillteann Potato Field (Group 1739)
		CreateSpawner(race: 60002, amount: 2, region: 300, coordinates: A(231125,196788, 231125,197856, 232102,197856, 232102,196788));  // Rooster
		CreateSpawner(race: 60003, amount: 5, region: 300, coordinates: A(231125,196788, 231125,197856, 232102,197856, 232102,196788));  // Hen
		CreateSpawner(race: 60004, amount: 5, region: 300, coordinates: A(231125,196788, 231125,197856, 232102,197856, 232102,196788));  // Chick
		
		// Taillteann Potato Field (Group 1740)
		CreateSpawner(race: 60002, amount: 4, region: 300, coordinates: A(230952,194609, 230952,195965, 232635,195965, 232635,194609));  // Rooster
		CreateSpawner(race: 60003, amount: 10, region: 300, coordinates: A(230952,194609, 230952,195965, 232635,195965, 232635,194609));  // Hen
		CreateSpawner(race: 60004, amount: 8, region: 300, coordinates: A(230952,194609, 230952,195965, 232635,195965, 232635,194609));  // Chick

		// North East of Taillteann (Group 1726)
		CreateSpawner(race: 50001, amount: 3, region: 300, coordinates: A(231508,208737, 231508,217424, 238396,217424, 238396,208737));  // Brown Fox
		CreateSpawner(race: 50007, amount: 5, region: 300, coordinates: A(231508,208737, 231508,217424, 238396,217424, 238396,208737));  // Young Brown Fox

		// North of Taillteann (Group 1727)
		CreateSpawner(race: 20007, amount: 3, region: 300, coordinates: A(236970,221700, 243179,229475, 245340,227750, 239130,219975));  // Black Dire Wolf
		CreateSpawner(race: 20011, amount: 12, region: 300, delay: 150, delayMin: 5, delayMax: 5, coordinates: A(236970,221700, 243179,229475, 245340,227750, 239130,219975));  // Black Dire Wolf Cub

		// North - Cemetery (Group 1735)
		CreateSpawner(race: 70801, amount: 10, region: 300, delay: 200, delayMin: 10, delayMax: 10, titles: A(30020, 0, 0), coordinates: A(246009,230806, 242560,234542, 249748,241177, 253197,237440));  // Burgundy Bear

	}
}


