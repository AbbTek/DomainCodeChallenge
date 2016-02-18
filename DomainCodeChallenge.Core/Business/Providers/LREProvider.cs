using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCodeChallenge.Core.Domain;

namespace DomainCodeChallenge.Core.Business.Providers
{
    public class LREProvider : PropertyMatcher
    {
        private const double maxDistance = 200;
        public override string AgencyCode
        {
            get
            {
                return "LRE";
            }
        }

        public override bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            var distance = GetDistance(agencyProperty.Latitude, agencyProperty.Longitude, databaseProperty.Latitude, databaseProperty.Longitude);
            return (distance <= maxDistance) && (agencyProperty.AgencyCode == databaseProperty.AgencyCode);
        }

        /// <summary>
        /// Get the distance between two points
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lon1"></param>
        /// <param name="lat2"></param>
        /// <param name="lon2"></param>
        /// <returns>In meters</returns>
        private double GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double theta = lon1 - lon2;
            double dist = Math.Sin(Deg2rad(lat1)) * Math.Sin(Deg2rad(lat2)) + Math.Cos(Deg2rad(lat1)) * Math.Cos(Deg2rad(lat2)) * Math.Cos(Deg2rad(theta));
            dist = Math.Acos(dist);
            dist = Rad2deg(dist);
            dist = dist * 60 * 1853.159616;
            return (dist);
        }

        private double Deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private double Rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
    }
}
