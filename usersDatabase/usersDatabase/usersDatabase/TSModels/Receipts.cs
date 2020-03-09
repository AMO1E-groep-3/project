using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TooSharp.Models
{   
    /// <summary>
    ///  TooSharp Generated Code. Do not Modify 
    ///  Date Genereated: 2/20/2020 8:57 PM
    ///  Author: jamil
    /// </summary>
    /// <seealso cref="TooSharp.Core.ITSRelationShips" />
    [DebuggerStepThrough]
    public class Receipts : TooSharp.Core.ITSModel
    {
      #region CODE
	     public static string TableName = "receipts";
         public string GetTableName() { return TableName; }
         public List<string> GetColumns() {return Enum.GetValues(typeof(COLUMNS)).Cast<COLUMNS>().Select(v => v.ToString()).ToList();  }
         public static TooSharp.Core.TSQueryBuilder<Receipt> Records() { return new TooSharp.Core.TSQueryBuilder<Receipt>(TooSharp.TSRelationships.getInstance()); }
         public static TooSharp.Core.TSQueryBuilder<Receipt> Records(object[] columns) { return new TooSharp.Core.TSQueryBuilder<Receipt>(TooSharp.TSRelationships.getInstance(),columns); }
      #endregion
      #region COLUMNS
       public enum COLUMNS
       {
         id,
         producten,
         totalprice,
         datum,
         //column
       }
      #endregion
    }
     [DebuggerStepThrough]
    public class Receipt: TooSharp.Core.TSmodel 
    {
     
       #region PROPERTIES
         [TSKey]
         public int Id { get; private set; }=-1;
         public string Producten { get; set; }
         public int Totalprice { get; set; }
         public DateTime Datum { get; set; }
         //property
       #endregion
    }
}
