namespace BuilderPattern
{
    public class House
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }
        public string Doors { get; set; }

        public override string ToString()
        {
            return $"Walls: {Walls}, Roof: {Roof}, Windows: {Windows}, Doors: {Doors}";
        }
    }

    public interface IHouseBuilder<T>
    {
        IHouseBuilder<T> BuildWalls(string walls); 
        IHouseBuilder<T> BuildRoof(string roof); 
        IHouseBuilder<T> BuildWindows(string windows); 
        IHouseBuilder<T> BuildDoors(string doors);
        T GetBuilder();
    }

    public class HouseBuilder:IHouseBuilder<House>
    {
        private House _house = new House();
        public IHouseBuilder<House> BuildWalls(string walls)
        {
            _house.Walls = walls;
            return this;
        }

        public IHouseBuilder<House> BuildRoof(string roof)
        {
            _house.Roof = roof;
            return this;
        }

        public IHouseBuilder<House> BuildWindows(string windows)
        {
            _house.Windows = windows;
            return this;
        }

        public IHouseBuilder<House> BuildDoors(string doors)
        {
            _house.Doors = doors;
            return this;
        }

        public House GetBuilder()
        {
            return _house;
        }
    }
}