using System;


namespace labi
{

class Koord
    {
        public int Degrees;     // градусы
        public float Minutes;   // минуты
        public char Direction;  // N, S, E, W

        public Koord(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }

        // Перевод в десятичные градусы
        public double ToDecimal()
        {
            double value = Degrees + Minutes / 60.0;

            if (Direction == 'S' || Direction == 'W')
                value = -value;

            return value;
        }

        // Расстояние между двумя точками
        // lat1, lon1 — первая точка
        // lat2, lon2 — вторая точка
        public static double Distance(Koord lat1, Koord lon1, Koord lat2, Koord lon2)
        {
            double lat1Deg = lat1.ToDecimal();
            double lat2Deg = lat2.ToDecimal();
            double lon1Deg = lon1.ToDecimal();
            double lon2Deg = lon2.ToDecimal();

            double dLat = (lat2Deg - lat1Deg) * 111.0;
            double avgLatRad = (lat1Deg + lat2Deg) / 2 * Math.PI / 180.0;
            double dLon = (lon2Deg - lon1Deg) * 111.0 * Math.Cos(avgLatRad);

            return Math.Sqrt(dLat * dLat + dLon * dLon);
        }
    }
}

