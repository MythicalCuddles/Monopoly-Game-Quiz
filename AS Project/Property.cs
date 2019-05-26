using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Project
{
    public enum PropertyColour
    {
        Pink,
        Blue,
        Orange,
        Yellow,
        Green,
        Brown,
        Grey,
        Purple,
        Undefined
    };

    public class Property
    {
        private string _propertyName;
        private int _propertyCost;
        private int _propertyRent;
        private Player _propertyOwner;
        private PropertyColour _propertyColour;

        public Property()
        {
            _propertyName = null;
            _propertyCost = 0;
            _propertyRent = 0;
            _propertyColour = PropertyColour.Undefined;
        }

        public Property(string PropertyName, int PropertyCost, int PropertyRent, PropertyColour PropertyColour)
        {
            _propertyName = PropertyName;
            _propertyCost = PropertyCost;
            _propertyRent = PropertyRent;
            _propertyColour = PropertyColour;
        }

        public string Name
        {
            get { return _propertyName; }
            set { _propertyName = value; }
        }

        public int Cost
        {
            get
            {
                return _propertyCost;
            }
            set
            {
                _propertyCost = value;
            }
        }

        public int Rent
        {
            get
            {
                return _propertyRent;
            }
            set
            {
                _propertyRent = value;
            }
        }

        public Player Owner
        {
            get
            {
                return _propertyOwner;
            }
            set
            {
                _propertyOwner = value;
            }
        }

        public PropertyColour Color
        {
            get
            {
                return _propertyColour;
            }
            set
            {
                _propertyColour = value;
            }
        }
    }
}
