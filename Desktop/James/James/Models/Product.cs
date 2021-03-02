//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace James.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OfferDate = new HashSet<OfferDate>();
            this.OrderList = new HashSet<OrderList>();
        }
    
        public int pId { get; set; }
        public string pName { get; set; }
        public Nullable<decimal> pPrice { get; set; }
        public byte[] pImg { get; set; }
        public string pInfo { get; set; }
        public Nullable<System.DateTime> pDate { get; set; }
        public Nullable<decimal> pRate { get; set; }
        public string pRContent { get; set; }
        public string pNum { get; set; }
        public Nullable<int> sId { get; set; }
        public Nullable<int> rId { get; set; }
        public string pImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferDate> OfferDate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderList> OrderList { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Style Style { get; set; }
    }
}