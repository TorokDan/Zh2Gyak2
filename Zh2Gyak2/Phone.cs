namespace Zh2Gyak2
{
    enum FaultCause { OS, AC, OK }
    class Phone 
    {
        public string ID { get; }
        public string Type { get; }
        public int[] BatteryLevels { get; }
        public FaultCause FC { get; set; }

        public Phone(string id, string type, string[] batterLevels)
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
