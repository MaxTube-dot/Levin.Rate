namespace Levin.Rate.Models.Valute
{
    /// <summary>
    /// Несколько валют получаемых с сервера.
    /// </summary>
    #region AttributeValCurs
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    #endregion
   
    public partial class ValutesCurs
    {

        private ValuteCurs[] valuteField;

        private string dateField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Valute")]
        public ValuteCurs[] Valute
        {
            get
            {
                return this.valuteField;
            }
            set
            {
                this.valuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
    }


}
