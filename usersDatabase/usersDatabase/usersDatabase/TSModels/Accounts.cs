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
    public class Accounts : TooSharp.Core.ITSModel
    {
      #region CODE
	     public static string TableName = "accounts";
         public string GetTableName() { return TableName; }
         public List<string> GetColumns() {return Enum.GetValues(typeof(COLUMNS)).Cast<COLUMNS>().Select(v => v.ToString()).ToList();  }
         public static TooSharp.Core.TSQueryBuilder<Account> Records() { return new TooSharp.Core.TSQueryBuilder<Account>(TooSharp.TSRelationships.getInstance()); }
         public static TooSharp.Core.TSQueryBuilder<Account> Records(object[] columns) { return new TooSharp.Core.TSQueryBuilder<Account>(TooSharp.TSRelationships.getInstance(),columns); }
      #endregion
      #region COLUMNS
       public enum COLUMNS
       {
         id,
         name,
         saldo,
         gratisDrank,
         email,
         rol,
         //column
       }
      #endregion
    }
     [DebuggerStepThrough]
    public class Account: TooSharp.Core.TSmodel 
    {
     
       #region PROPERTIES
         [TSKey]
         public int Id { get; private set; }=-1;
         [TSName]
         public string Name { get; set; }
         [TSNotEmpty]
         public int Saldo { get; set; }
         [TSNotEmpty]
         public int GratisDrank { get; set; }
         [TSEmail]
         public string Email { get; set; }
         [TSNotEmpty]
         public string Rol { get; set; }
         //property
       #endregion
    }
}
