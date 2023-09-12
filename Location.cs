
public class Location
{
    public string ID;
    public string Name;
    public string Description;

    public Location(string id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;
    }
    public Location GetLocationAt(string direction)
        {
            switch (direction)
            {
                case "N":
                    return LocationToNorth;
                case "E":
                    return LocationToEast;
                case "S":
                    return LocationToSouth;
                case "W":
                    return LocationToWest;
                default:
                    return null;
            }
        }

        public string Compass()
        {
            string compass = "";
            if (LocationToNorth != null)
            {
                compass += "    N\n    |\n";
            }

            if (LocationToWest != null)
            {
                compass += "W---|";
            }
            else
            {
                compass += "    |";
            }
            
            if (LocationToEast != null)
            {
                compass += "---E\n";
            }
            else
            {
                compass += "\n";
            }
            if (LocationToSouth != null)
            {
                compass += "    |\n    S";
            }

            return compass;
        }
    }
}
}
