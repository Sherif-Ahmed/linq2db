// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SQLiteNorthwind
{
	[Table("Shippers")]
	public class Shipper : IEquatable<Shipper>
	{
		[Column("ShipperID"  , DataType  = DataType.Int32  , DbType   = "int"           , Length = 4            , Precision = 10, Scale     = 0, IsPrimaryKey = true)] public int     ShipperId   { get; set; } // int
		[Column("CompanyName", CanBeNull = false           , DataType = DataType.VarChar, DbType = "varchar(40)", Length    = 40, Precision = 0, Scale        = 0   )] public string  CompanyName { get; set; } = null!; // varchar(40)
		[Column("Phone"      , DataType  = DataType.VarChar, DbType   = "varchar(24)"   , Length = 24           , Precision = 0 , Scale     = 0                     )] public string? Phone       { get; set; } // varchar(24)

		#region IEquatable<T> support
		private static readonly IEqualityComparer<Shipper> _equalityComparer = ComparerBuilder.GetEqualityComparer<Shipper>(c => c.ShipperId);

		public bool Equals(Shipper? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as Shipper);
		}
		#endregion
	}
}