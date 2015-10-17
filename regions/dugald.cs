//--- Aura Script -----------------------------------------------------------
// Dugald Aisle (16)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Dugald.
// Region between Tir and Dunbarton.
//---------------------------------------------------------------------------

public class DugaldRegionScript : RegionScript
{
	public override void LoadWarps()
	{
		// Residential
		SetPropBehavior(0x00A00010000600BA, PropWarp(16,43104,55693, 200,7615,14099));
		SetPropBehavior(0x00A000C8000F029B, PropWarp(200,7233,14023, 16,42571,55698));
	}
	
	public override void LoadSpawns()
	{	
		// Dugald Isle Southern Path (Group 24)
		CreateSpawner(race: 50001, amount: 1, region: 16, coordinates: A(25134,33728, 21904,21680, 15279,23457, 18508,35504));  // Brown Fox
		CreateSpawner(race: 50007, amount: 1, region: 16, coordinates: A(25134,33728, 21904,21680, 15279,23457, 18508,35504));  // Young Brown Fox
		CreateSpawner(race: 50101, amount: 2, region: 16, coordinates: A(25134,33728, 21904,21680, 15279,23457, 18508,35504));  // Raccoon
		CreateSpawner(race: 50102, amount: 1, region: 16, coordinates: A(25134,33728, 21904,21680, 15279,23457, 18508,35504));  // Young Raccoon
		CreateSpawner(race: 70001, amount: 1, region: 16, coordinates: A(25134,33728, 21904,21680, 15279,23457, 18508,35504));  // Brown Bear

		// Dugald Isle Northern Path (Group 20)
		CreateSpawner(race: 20001, amount: 1, region: 16, delay: 900, delayMin: 10, delayMax: 10, coordinates: A(28257,88600, 26523,76485, 23533,76913, 25267,89028));  // Gray Wolf
		CreateSpawner(race: 20101, amount: 5, region: 16, coordinates: A(28257,88600, 26523,76485, 23533,76913, 25267,89028));  // Dog
		CreateSpawner(race: 40001, amount: 10, region: 16, coordinates: A(28257,88600, 26523,76485, 23533,76913, 25267,89028));  // Sheep

		// Dugald Isle South-West (Group 23)
		CreateSpawner(race: 20007, amount: 4, region: 16, coordinates: A(9428,17114, 13667,34454, 18522,33267, 14283,15927));  // Black Dire Wolf
		CreateSpawner(race: 20011, amount: 8, region: 16, coordinates: A(9428,17114, 13667,34454, 18522,33267, 14283,15927));  // Black Dire Wolf Kid

		// Dugald Isle Spiral Hill (Group 25)
		CreateSpawner(race: 20008, amount: 2, region: 16, coordinates: A(35806,20718, 35806,28231, 38608,28231, 38608,20718));  // White Dire Wolf
		CreateSpawner(race: 20012, amount: 4, region: 16, coordinates: A(35806,20718, 35806,28231, 38608,28231, 38608,20718));  // White Dire Wolf Kid
		CreateSpawner(race: 50003, amount: 1, region: 16, coordinates: A(35806,20718, 35806,28231, 38608,28231, 38608,20718));  // Gray Fox
		CreateSpawner(race: 80101, amount: 1, region: 16, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(35806,20718, 35806,28231, 38608,28231, 38608,20718));  // Whisp

		CreateSpawner(race: 20008, amount: 2, region: 16, coordinates: A(31994,15667, 30954,17379, 36419,20697, 37459,18985));  // White Dire Wolf
		CreateSpawner(race: 20012, amount: 4, region: 16, coordinates: A(31994,15667, 30954,17379, 36419,20697, 37459,18985));  // White Dire Wolf Kid
		CreateSpawner(race: 50003, amount: 1, region: 16, coordinates: A(31994,15667, 30954,17379, 36419,20697, 37459,18985));  // Gray Fox
		CreateSpawner(race: 80101, amount: 1, region: 16, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(31994,15667, 30954,17379, 36419,20697, 37459,18985));  // Whisp

		CreateSpawner(race: 20008, amount: 2, region: 16, coordinates: A(28969,28947, 28969,30785, 34645,30785, 34645,28947));  // White Dire Wolf
		CreateSpawner(race: 20012, amount: 4, region: 16, coordinates: A(28969,28947, 28969,30785, 34645,30785, 34645,28947));  // White Dire Wolf Kid
		CreateSpawner(race: 50003, amount: 1, region: 16, coordinates: A(28969,28947, 28969,30785, 34645,30785, 34645,28947));  // Gray Fox
		CreateSpawner(race: 80101, amount: 1, region: 16, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(28969,28947, 28969,30785, 34645,30785, 34645,28947));  // Whisp

		// Dugald Isle West Forest (Group 21)
		CreateSpawner(race: 20001, amount: 2, region: 16, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Gray Wolf
		CreateSpawner(race: 20005, amount: 1, region: 16, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Brown Dire Wolf
		CreateSpawner(race: 50101, amount: 1, region: 16, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Raccoon
		CreateSpawner(race: 50102, amount: 1, region: 16, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Young Raccoon
		CreateSpawner(race: 70001, amount: 3, region: 16, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Brown Bear
		CreateSpawner(race: 70002, amount: 2, region: 16, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Red Bear
		CreateSpawner(race: 80101, amount: 1, region: 16, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(6435,56086, 6435,63862, 15294,63862, 15294,56086));  // Whisp

		// Dugald Isle Southern Path near Dunbarton warp (Group 26)
		CreateSpawner(race: 20101, amount: 2, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // Dog
		CreateSpawner(race: 40001, amount: 10, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // Sheep
		CreateSpawner(race: 30014, amount: 1, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // White Field Spider
		CreateSpawner(race: 50001, amount: 1, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // Brown Fox
		CreateSpawner(race: 50002, amount: 1, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // Red Fox
		CreateSpawner(race: 50101, amount: 1, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // Raccoon
		CreateSpawner(race: 50102, amount: 1, region: 16, coordinates: A(15707,11564, 15707,19927, 23971,19927, 23971,11564));  // Young Raccoon

		// North of Dugald Isle Logging Camp (Group 27)
		CreateSpawner(race: 50101, amount: 12, region: 16, coordinates: A(19585,67694, 25346,67824, 25406,65191, 19645,65061));  // Raccoon
		CreateSpawner(race: 50102, amount: 8, region: 16, coordinates: A(19585,67694, 25346,67824, 25406,65191, 19645,65061));  // Young Raccoon

		// Dugald Isle Near Residential (Group 28)
		CreateSpawner(race: 110002, amount: 1, region: 16, coordinates: A(42294,54926, 42294,55179, 42494,55179, 42494,54926));  // Cow

		// Dugald Isle Logging Camp Animals (Group 49)
		CreateSpawner(race: 60002, amount: 4, region: 16, coordinates: A(20183,56543, 20183,61037, 24617,61037, 24617,56543));  // Rooster
		CreateSpawner(race: 60003, amount: 10, region: 16, coordinates: A(20183,56543, 20183,61037, 24617,61037, 24617,56543));  // Hen
		CreateSpawner(race: 60004, amount: 5, region: 16, coordinates: A(20183,56543, 20183,61037, 24617,61037, 24617,56543));  // Chick

		// Dugald Isle Logging Camp Northern end (Group 29)
		CreateSpawner(race: 50001, amount: 10, region: 16, coordinates: A(18062,60432, 18062,63488, 25893,63488, 25893,60432));  // Brown Fox
		CreateSpawner(race: 50007, amount: 5, region: 16, coordinates: A(18062,60432, 18062,63488, 25893,63488, 25893,60432));  // Young Brown Fox
		CreateSpawner(race: 60002, amount: 1, region: 16, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(18062,60432, 18062,63488, 25893,63488, 25893,60432));  // Rooster
		CreateSpawner(race: 60003, amount: 2, region: 16, delay: 300, delayMin: 10, delayMax: 10, coordinates: A(18062,60432, 18062,63488, 25893,63488, 25893,60432));  // Hen

		// Dugald Isle Logging Camp (Group 22)
		CreateSpawner(race: 50101, amount: 10, region: 16, coordinates: A(18859,40324, 22205,49235, 26890,47476, 23544,38564));  // Raccoon
		CreateSpawner(race: 50102, amount: 10, region: 16, coordinates: A(18859,40324, 22205,49235, 26890,47476, 23544,38564));  // Young Raccoon

		// Bosses
		// Giant Bear 70016 with 2x Grizzly 70004
		// Black Warrior 10095
	}
}