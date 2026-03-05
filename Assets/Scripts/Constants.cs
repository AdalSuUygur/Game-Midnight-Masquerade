using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class Constants
    {
        //TileMap Names
        public const string TileMapNameAristocrat = "Tilemap_Aristocrat";
        public const string TileMapNameMaid = "Tilemap_Maid";
        public const string TileMapNameMusician = "Tilemap_Musician";
        public const string TileMapNameGround = "Tilemap_Ground";
        public const string TileMapNameWall = "Tilemap_Wall";

        //Mask Names
        public const string RedMask = "RedMask";
        public const string GreenMask = "GreenMask";
        public const string BlueMask = "BlueMask";

        //ZoneType Enum

        public enum ZoneType
        {
            RedZone,
            BlueZone,
            GreenZone,
            Ground
        }

    }
}
