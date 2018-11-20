namespace welltrak
{
    public class Address: Entity
    {
        public string StreetAddress1;
        public string StreetAddress2;
        public string City;
        public string State;
        public string ZipCode;

        public string GetAddressBlockString()
        {
            if(string.IsNullOrEmpty(StreetAddress2))
            {
                return $"{StreetAddress1}\n{City}, {State} {ZipCode}";
            }
            return $"{StreetAddress1}\n{StreetAddress2}\n{City}, {State} {ZipCode}";

        }

        public string GetAddressLineString()
        {
			if (string.IsNullOrEmpty(StreetAddress2))
			{
				return $"{StreetAddress1} {City}, {State} {ZipCode}";
			}
            return $"{StreetAddress1} {StreetAddress2} {City}, {State} {ZipCode}";
        }
    }
}