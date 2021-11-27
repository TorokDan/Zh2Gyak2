namespace Zh2Gyak2
{
    class Analyzer 
    {
        Phone[] phones;

        public Analyzer()
        {
            string[] adatok = FileHandler.Load();
            phones = new Phone[adatok.Length];
            for (int i = 0; i < adatok.Length; i++)
            {
                string[] tmpString = adatok[i].Split(':');
                phones[i] = new Phone(tmpString[0], tmpString[1], tmpString[2].Split(';'));
            }
        }

        private bool OSCause(Phone phone)
        {
            for (int i = 1; i < phone.BatteryLevels.Length; i++)
            {

                if (phone.BatteryLevels[i-1] == 30 && phone.BatteryLevels[i] < 5)
                {
                    phone.FC = FaultCause.OS;
                    return true;
                }
            }
            return false;
        }
        private bool ACCause(Phone phone)
        {
            for (int i = 1; i < phone.BatteryLevels.Length; i++)
            {
                if (phone.BatteryLevels[i - 1] - phone.BatteryLevels[i] > 7)
                {
                    phone.FC = FaultCause.AC;
                    return true;
                }
            }
            return false;
        }

        public void Analysis()
        {
            for (int i = 0; i < phones.Length; i++)
            {
                if (!OSCause(phones[i]))
                    ACCause(phones[i]);
                FileHandler.Append(phones[i].ToString());
            }
        }

    }
}
