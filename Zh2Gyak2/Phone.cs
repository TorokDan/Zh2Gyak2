namespace Zh2Gyak2
{
    enum FaultCause { OS, AC, OK }
    class Phone 
    {
        public int ID { get; }
        public string Type { get; }
        public int[] BatteryLevels { get; }
        public FaultCause FC { get; set; }

        public Phone(int id, string type, string[] batterLevels)
        {
            ID = id;
            Type = type;
            BatteryLevels = new int[batterLevels.Length];
            for (int i = 0; i < batterLevels.Length; i++)
            {
                BatteryLevels[i] = int.Parse(batterLevels[i]);
            }
            FC = FaultCause.OK;
        }

        public override string ToString()
        {
            return $"{ID}:{FC}";
        }
    }
}
