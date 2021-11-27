using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Levin.Rate.Models.Valute
{



    /// <summary>
    /// Валюта и ее описание.
    /// </summary>
    #region AttributeValCursValute
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    #endregion

    public partial class ValuteCurs
    {

        private ushort numCodeField;

        private string charCodeField;

        private ushort nominalField;

        private string nameField;

        private string valueField;

        private string idField;

        /// <remarks/>
        public ushort NumCode
        {
            get
            {
                return this.numCodeField;
            }
            set
            {
                this.numCodeField = value;
            }
        }

        /// <remarks/>
        public string CharCode
        {
            get
            {
                return this.charCodeField;
            }
            set
            {
                this.charCodeField = value;
            }
        }

        /// <remarks/>
        public ushort Nominal
        {
            get
            {
                return this.nominalField;
            }
            set
            {
                this.nominalField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }


}
