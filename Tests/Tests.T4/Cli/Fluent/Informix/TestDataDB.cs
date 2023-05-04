// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;
using System.Linq;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.Informix
{
	public partial class TestDataDB : DataConnection
	{
		static TestDataDB()
		{
			var builder = new FluentMappingBuilder(ContextSchema);

			builder
				.Entity<Alltype>()
					.HasAttribute(new TableAttribute("alltypes"))
					.Member(e => e.Id)
						.HasAttribute(new ColumnAttribute("id")
						{
							IsPrimaryKey = true,
							IsIdentity = true,
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.Bigintdatatype)
						.HasAttribute(new ColumnAttribute("bigintdatatype"))
					.Member(e => e.Int8Datatype)
						.HasAttribute(new ColumnAttribute("int8datatype"))
					.Member(e => e.Intdatatype)
						.HasAttribute(new ColumnAttribute("intdatatype"))
					.Member(e => e.Smallintdatatype)
						.HasAttribute(new ColumnAttribute("smallintdatatype"))
					.Member(e => e.Decimaldatatype)
						.HasAttribute(new ColumnAttribute("decimaldatatype"))
					.Member(e => e.Moneydatatype)
						.HasAttribute(new ColumnAttribute("moneydatatype"))
					.Member(e => e.Realdatatype)
						.HasAttribute(new ColumnAttribute("realdatatype"))
					.Member(e => e.Floatdatatype)
						.HasAttribute(new ColumnAttribute("floatdatatype"))
					.Member(e => e.Booldatatype)
						.HasAttribute(new ColumnAttribute("booldatatype"))
					.Member(e => e.Chardatatype)
						.HasAttribute(new ColumnAttribute("chardatatype"))
					.Member(e => e.Char20Datatype)
						.HasAttribute(new ColumnAttribute("char20datatype"))
					.Member(e => e.Varchardatatype)
						.HasAttribute(new ColumnAttribute("varchardatatype"))
					.Member(e => e.Nchardatatype)
						.HasAttribute(new ColumnAttribute("nchardatatype"))
					.Member(e => e.Nvarchardatatype)
						.HasAttribute(new ColumnAttribute("nvarchardatatype"))
					.Member(e => e.Lvarchardatatype)
						.HasAttribute(new ColumnAttribute("lvarchardatatype"))
					.Member(e => e.Textdatatype)
						.HasAttribute(new ColumnAttribute("textdatatype"))
					.Member(e => e.Datedatatype)
						.HasAttribute(new ColumnAttribute("datedatatype"))
					.Member(e => e.Datetimedatatype)
						.HasAttribute(new ColumnAttribute("datetimedatatype"))
					.Member(e => e.Intervaldatatype)
						.HasAttribute(new ColumnAttribute("intervaldatatype"))
					.Member(e => e.Bytedatatype)
						.HasAttribute(new ColumnAttribute("bytedatatype"));

			builder
				.Entity<Child>()
					.HasAttribute(new TableAttribute("child"))
					.Member(e => e.Parentid)
						.HasAttribute(new ColumnAttribute("parentid"))
					.Member(e => e.Childid)
						.HasAttribute(new ColumnAttribute("childid"));

			builder
				.Entity<Collatedtable>()
					.HasAttribute(new TableAttribute("collatedtable"))
					.Member(e => e.Id)
						.HasAttribute(new ColumnAttribute("id"))
					.Member(e => e.Casesensitive)
						.HasAttribute(new ColumnAttribute("casesensitive")
						{
							CanBeNull = false
						})
					.Member(e => e.Caseinsensitive)
						.HasAttribute(new ColumnAttribute("caseinsensitive")
						{
							CanBeNull = false
						});

			builder
				.Entity<Doctor>()
					.HasAttribute(new TableAttribute("doctor"))
					.Member(e => e.Personid)
						.HasAttribute(new ColumnAttribute("personid")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.Taxonomy)
						.HasAttribute(new ColumnAttribute("taxonomy")
						{
							CanBeNull = false
						})
					.Member(e => e.Person)
						.HasAttribute(new AssociationAttribute()
						{
							CanBeNull = false,
							ThisKey = nameof(Doctor.Personid),
							OtherKey = nameof(Person.Personid)
						});

			builder
				.Entity<Grandchild>()
					.HasAttribute(new TableAttribute("grandchild"))
					.Member(e => e.Parentid)
						.HasAttribute(new ColumnAttribute("parentid"))
					.Member(e => e.Childid)
						.HasAttribute(new ColumnAttribute("childid"))
					.Member(e => e.Grandchildid)
						.HasAttribute(new ColumnAttribute("grandchildid"));

			builder
				.Entity<Inheritancechild>()
					.HasAttribute(new TableAttribute("inheritancechild"))
					.Member(e => e.Inheritancechildid)
						.HasAttribute(new ColumnAttribute("inheritancechildid")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.Inheritanceparentid)
						.HasAttribute(new ColumnAttribute("inheritanceparentid"))
					.Member(e => e.Typediscriminator)
						.HasAttribute(new ColumnAttribute("typediscriminator"))
					.Member(e => e.Name)
						.HasAttribute(new ColumnAttribute("name"));

			builder
				.Entity<Inheritanceparent>()
					.HasAttribute(new TableAttribute("inheritanceparent"))
					.Member(e => e.Inheritanceparentid)
						.HasAttribute(new ColumnAttribute("inheritanceparentid")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.Typediscriminator)
						.HasAttribute(new ColumnAttribute("typediscriminator"))
					.Member(e => e.Name)
						.HasAttribute(new ColumnAttribute("name"));

			builder
				.Entity<Linqdatatype>()
					.HasAttribute(new TableAttribute("linqdatatypes"))
					.Member(e => e.Id)
						.HasAttribute(new ColumnAttribute("id"))
					.Member(e => e.Moneyvalue)
						.HasAttribute(new ColumnAttribute("moneyvalue"))
					.Member(e => e.Datetimevalue)
						.HasAttribute(new ColumnAttribute("datetimevalue"))
					.Member(e => e.Datetimevalue2)
						.HasAttribute(new ColumnAttribute("datetimevalue2"))
					.Member(e => e.Boolvalue)
						.HasAttribute(new ColumnAttribute("boolvalue"))
					.Member(e => e.Guidvalue)
						.HasAttribute(new ColumnAttribute("guidvalue"))
					.Member(e => e.Binaryvalue)
						.HasAttribute(new ColumnAttribute("binaryvalue"))
					.Member(e => e.Smallintvalue)
						.HasAttribute(new ColumnAttribute("smallintvalue"))
					.Member(e => e.Intvalue)
						.HasAttribute(new ColumnAttribute("intvalue"))
					.Member(e => e.Bigintvalue)
						.HasAttribute(new ColumnAttribute("bigintvalue"))
					.Member(e => e.Stringvalue)
						.HasAttribute(new ColumnAttribute("stringvalue"));

			builder
				.Entity<Parent>()
					.HasAttribute(new TableAttribute("parent"))
					.Member(e => e.Parentid)
						.HasAttribute(new ColumnAttribute("parentid"))
					.Member(e => e.Value1)
						.HasAttribute(new ColumnAttribute("value1"));

			builder
				.Entity<Patient>()
					.HasAttribute(new TableAttribute("patient"))
					.Member(e => e.Personid)
						.HasAttribute(new ColumnAttribute("personid")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.Diagnosis)
						.HasAttribute(new ColumnAttribute("diagnosis")
						{
							CanBeNull = false
						})
					.Member(e => e.Person)
						.HasAttribute(new AssociationAttribute()
						{
							CanBeNull = false,
							ThisKey = nameof(Patient.Personid),
							OtherKey = nameof(Person.Personid)
						});

			builder
				.Entity<Person>()
					.HasAttribute(new TableAttribute("person"))
					.Member(e => e.Personid)
						.HasAttribute(new ColumnAttribute("personid")
						{
							IsPrimaryKey = true,
							IsIdentity = true,
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.Firstname)
						.HasAttribute(new ColumnAttribute("firstname")
						{
							CanBeNull = false
						})
					.Member(e => e.Lastname)
						.HasAttribute(new ColumnAttribute("lastname")
						{
							CanBeNull = false
						})
					.Member(e => e.Middlename)
						.HasAttribute(new ColumnAttribute("middlename"))
					.Member(e => e.Gender)
						.HasAttribute(new ColumnAttribute("gender"))
					.Member(e => e.Doctor)
						.HasAttribute(new AssociationAttribute()
						{
							ThisKey = nameof(Person.Personid),
							OtherKey = nameof(Doctor.Personid)
						})
					.Member(e => e.Patient)
						.HasAttribute(new AssociationAttribute()
						{
							ThisKey = nameof(Person.Personid),
							OtherKey = nameof(Patient.Personid)
						});

			builder
				.Entity<Testfkunique>()
					.HasAttribute(new TableAttribute("testfkunique"))
					.Member(e => e.Id1)
						.HasAttribute(new ColumnAttribute("id1"))
					.Member(e => e.Id2)
						.HasAttribute(new ColumnAttribute("id2"))
					.Member(e => e.Id3)
						.HasAttribute(new ColumnAttribute("id3"))
					.Member(e => e.Id4)
						.HasAttribute(new ColumnAttribute("id4"))
					.Member(e => e.Testunique)
						.HasAttribute(new AssociationAttribute()
						{
							CanBeNull = false,
							ThisKey = nameof(Testfkunique.Id1) + "," + nameof(Testfkunique.Id2),
							OtherKey = nameof(Testunique.Id1) + "," + nameof(Testunique.Id2)
						})
					.Member(e => e.Testunique1)
						.HasAttribute(new AssociationAttribute()
						{
							CanBeNull = false,
							ThisKey = nameof(Testfkunique.Id3) + "," + nameof(Testfkunique.Id4),
							OtherKey = nameof(Testunique.Id3) + "," + nameof(Testunique.Id4)
						});

			builder
				.Entity<Testidentity>()
					.HasAttribute(new TableAttribute("testidentity"))
					.Member(e => e.Id)
						.HasAttribute(new ColumnAttribute("id")
						{
							IsPrimaryKey = true,
							IsIdentity = true,
							SkipOnInsert = true,
							SkipOnUpdate = true
						});

			builder
				.Entity<Testmerge1>()
					.HasAttribute(new TableAttribute("testmerge1"))
					.Member(e => e.Id)
						.HasAttribute(new ColumnAttribute("id")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.Field1)
						.HasAttribute(new ColumnAttribute("field1"))
					.Member(e => e.Field2)
						.HasAttribute(new ColumnAttribute("field2"))
					.Member(e => e.Field3)
						.HasAttribute(new ColumnAttribute("field3"))
					.Member(e => e.Field4)
						.HasAttribute(new ColumnAttribute("field4"))
					.Member(e => e.Field5)
						.HasAttribute(new ColumnAttribute("field5"))
					.Member(e => e.Fieldint64)
						.HasAttribute(new ColumnAttribute("fieldint64"))
					.Member(e => e.Fieldboolean)
						.HasAttribute(new ColumnAttribute("fieldboolean"))
					.Member(e => e.Fieldstring)
						.HasAttribute(new ColumnAttribute("fieldstring"))
					.Member(e => e.Fieldchar)
						.HasAttribute(new ColumnAttribute("fieldchar"))
					.Member(e => e.Fieldfloat)
						.HasAttribute(new ColumnAttribute("fieldfloat"))
					.Member(e => e.Fielddouble)
						.HasAttribute(new ColumnAttribute("fielddouble"))
					.Member(e => e.Fielddatetime)
						.HasAttribute(new ColumnAttribute("fielddatetime"))
					.Member(e => e.Fieldbinary)
						.HasAttribute(new ColumnAttribute("fieldbinary"))
					.Member(e => e.Fielddecimal)
						.HasAttribute(new ColumnAttribute("fielddecimal"))
					.Member(e => e.Fielddate)
						.HasAttribute(new ColumnAttribute("fielddate"))
					.Member(e => e.Fieldtime)
						.HasAttribute(new ColumnAttribute("fieldtime"))
					.Member(e => e.Fieldenumstring)
						.HasAttribute(new ColumnAttribute("fieldenumstring"))
					.Member(e => e.Fieldenumnumber)
						.HasAttribute(new ColumnAttribute("fieldenumnumber"));

			builder
				.Entity<Testmerge2>()
					.HasAttribute(new TableAttribute("testmerge2"))
					.Member(e => e.Id)
						.HasAttribute(new ColumnAttribute("id")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.Field1)
						.HasAttribute(new ColumnAttribute("field1"))
					.Member(e => e.Field2)
						.HasAttribute(new ColumnAttribute("field2"))
					.Member(e => e.Field3)
						.HasAttribute(new ColumnAttribute("field3"))
					.Member(e => e.Field4)
						.HasAttribute(new ColumnAttribute("field4"))
					.Member(e => e.Field5)
						.HasAttribute(new ColumnAttribute("field5"))
					.Member(e => e.Fieldint64)
						.HasAttribute(new ColumnAttribute("fieldint64"))
					.Member(e => e.Fieldboolean)
						.HasAttribute(new ColumnAttribute("fieldboolean"))
					.Member(e => e.Fieldstring)
						.HasAttribute(new ColumnAttribute("fieldstring"))
					.Member(e => e.Fieldchar)
						.HasAttribute(new ColumnAttribute("fieldchar"))
					.Member(e => e.Fieldfloat)
						.HasAttribute(new ColumnAttribute("fieldfloat"))
					.Member(e => e.Fielddouble)
						.HasAttribute(new ColumnAttribute("fielddouble"))
					.Member(e => e.Fielddatetime)
						.HasAttribute(new ColumnAttribute("fielddatetime"))
					.Member(e => e.Fieldbinary)
						.HasAttribute(new ColumnAttribute("fieldbinary"))
					.Member(e => e.Fielddecimal)
						.HasAttribute(new ColumnAttribute("fielddecimal"))
					.Member(e => e.Fielddate)
						.HasAttribute(new ColumnAttribute("fielddate"))
					.Member(e => e.Fieldtime)
						.HasAttribute(new ColumnAttribute("fieldtime"))
					.Member(e => e.Fieldenumstring)
						.HasAttribute(new ColumnAttribute("fieldenumstring"))
					.Member(e => e.Fieldenumnumber)
						.HasAttribute(new ColumnAttribute("fieldenumnumber"));

			builder
				.Entity<Testunique>()
					.HasAttribute(new TableAttribute("testunique"))
					.Member(e => e.Id1)
						.HasAttribute(new ColumnAttribute("id1")
						{
							IsPrimaryKey = true,
							PrimaryKeyOrder = 0
						})
					.Member(e => e.Id2)
						.HasAttribute(new ColumnAttribute("id2")
						{
							IsPrimaryKey = true,
							PrimaryKeyOrder = 1
						})
					.Member(e => e.Id3)
						.HasAttribute(new ColumnAttribute("id3"))
					.Member(e => e.Id4)
						.HasAttribute(new ColumnAttribute("id4"))
					.Member(e => e.Testfkuniques)
						.HasAttribute(new AssociationAttribute()
						{
							ThisKey = nameof(Testunique.Id1) + "," + nameof(Testunique.Id2),
							OtherKey = nameof(Testfkunique.Id1) + "," + nameof(Testfkunique.Id2)
						})
					.Member(e => e.Testfkuniques1)
						.HasAttribute(new AssociationAttribute()
						{
							ThisKey = nameof(Testunique.Id3) + "," + nameof(Testunique.Id4),
							OtherKey = nameof(Testfkunique.Id3) + "," + nameof(Testfkunique.Id4)
						});

			builder
				.Entity<Personview>()
					.HasAttribute(new TableAttribute("personview")
					{
						IsView = true
					})
					.Member(e => e.Personid)
						.HasAttribute(new ColumnAttribute("personid")
						{
							IsIdentity = true,
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.Firstname)
						.HasAttribute(new ColumnAttribute("firstname")
						{
							CanBeNull = false
						})
					.Member(e => e.Lastname)
						.HasAttribute(new ColumnAttribute("lastname")
						{
							CanBeNull = false
						})
					.Member(e => e.Middlename)
						.HasAttribute(new ColumnAttribute("middlename"))
					.Member(e => e.Gender)
						.HasAttribute(new ColumnAttribute("gender"));

			builder.HasAttribute<Doctor>(e => ExtensionMethods.Person(e, default(IDataContext)!), new AssociationAttribute()
			{
				CanBeNull = false,
				ThisKey = nameof(Doctor.Personid),
				OtherKey = nameof(Person.Personid)
			});

			builder.HasAttribute<Person>(e => ExtensionMethods.Doctor(e, default(IDataContext)!), new AssociationAttribute()
			{
				ThisKey = nameof(Person.Personid),
				OtherKey = nameof(Doctor.Personid)
			});

			builder.HasAttribute<Patient>(e => ExtensionMethods.Person(e, default(IDataContext)!), new AssociationAttribute()
			{
				CanBeNull = false,
				ThisKey = nameof(Patient.Personid),
				OtherKey = nameof(Person.Personid)
			});

			builder.HasAttribute<Person>(e => ExtensionMethods.Patient(e, default(IDataContext)!), new AssociationAttribute()
			{
				ThisKey = nameof(Person.Personid),
				OtherKey = nameof(Patient.Personid)
			});

			builder.HasAttribute<Testfkunique>(e => ExtensionMethods.Testunique(e, default(IDataContext)!), new AssociationAttribute()
			{
				CanBeNull = false,
				ThisKey = nameof(Testfkunique.Id1) + "," + nameof(Testfkunique.Id2),
				OtherKey = nameof(Testunique.Id1) + "," + nameof(Testunique.Id2)
			});

			builder.HasAttribute<Testunique>(e => ExtensionMethods.Testfkuniques(e, default(IDataContext)!), new AssociationAttribute()
			{
				ThisKey = nameof(Testunique.Id1) + "," + nameof(Testunique.Id2),
				OtherKey = nameof(Testfkunique.Id1) + "," + nameof(Testfkunique.Id2)
			});

			builder.HasAttribute<Testfkunique>(e => ExtensionMethods.Testunique1(e, default(IDataContext)!), new AssociationAttribute()
			{
				CanBeNull = false,
				ThisKey = nameof(Testfkunique.Id3) + "," + nameof(Testfkunique.Id4),
				OtherKey = nameof(Testunique.Id3) + "," + nameof(Testunique.Id4)
			});

			builder.HasAttribute<Testunique>(e => ExtensionMethods.Testfkuniques1(e, default(IDataContext)!), new AssociationAttribute()
			{
				ThisKey = nameof(Testunique.Id3) + "," + nameof(Testunique.Id4),
				OtherKey = nameof(Testfkunique.Id3) + "," + nameof(Testfkunique.Id4)
			});

			builder.Build();
		}
		public static MappingSchema ContextSchema { get; } = new MappingSchema();

		public TestDataDB()
			: base(new DataOptions().UseMappingSchema(ContextSchema))
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(new DataOptions().UseConfiguration(configuration, ContextSchema))
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options.UseMappingSchema(options.Options.ConnectionOptions.MappingSchema == null ? ContextSchema : MappingSchema.CombineSchemas(options.Options.ConnectionOptions.MappingSchema, ContextSchema)))
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<Alltype>           Alltypes            => this.GetTable<Alltype>();
		public ITable<Child>             Children            => this.GetTable<Child>();
		public ITable<Collatedtable>     Collatedtables      => this.GetTable<Collatedtable>();
		public ITable<Doctor>            Doctors             => this.GetTable<Doctor>();
		public ITable<Grandchild>        Grandchildren       => this.GetTable<Grandchild>();
		public ITable<Inheritancechild>  Inheritancechildren => this.GetTable<Inheritancechild>();
		public ITable<Inheritanceparent> Inheritanceparents  => this.GetTable<Inheritanceparent>();
		public ITable<Linqdatatype>      Linqdatatypes       => this.GetTable<Linqdatatype>();
		public ITable<Parent>            Parents             => this.GetTable<Parent>();
		public ITable<Patient>           Patients            => this.GetTable<Patient>();
		public ITable<Person>            People              => this.GetTable<Person>();
		public ITable<Testfkunique>      Testfkuniques       => this.GetTable<Testfkunique>();
		public ITable<Testidentity>      Testidentities      => this.GetTable<Testidentity>();
		public ITable<Testmerge1>        Testmerge1          => this.GetTable<Testmerge1>();
		public ITable<Testmerge2>        Testmerge2          => this.GetTable<Testmerge2>();
		public ITable<Testunique>        Testuniques         => this.GetTable<Testunique>();
		public ITable<Personview>        Personviews         => this.GetTable<Personview>();
	}

	public static partial class ExtensionMethods
	{
		#region Associations
		#region Doctor Associations
		/// <summary>
		/// FK_doctor_person
		/// </summary>
		public static Person Person(this Doctor obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.Personid == t.Personid);
		}
		#endregion

		#region Person Associations
		/// <summary>
		/// FK_doctor_person backreference
		/// </summary>
		public static Doctor? Doctor(this Person obj, IDataContext db)
		{
			return db.GetTable<Doctor>().FirstOrDefault(t => t.Personid == obj.Personid);
		}

		/// <summary>
		/// FK_patient_person backreference
		/// </summary>
		public static Patient? Patient(this Person obj, IDataContext db)
		{
			return db.GetTable<Patient>().FirstOrDefault(t => t.Personid == obj.Personid);
		}
		#endregion

		#region Patient Associations
		/// <summary>
		/// FK_patient_person
		/// </summary>
		public static Person Person(this Patient obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.Personid == t.Personid);
		}
		#endregion

		#region Testfkunique Associations
		/// <summary>
		/// FK_testfkunique_testunique
		/// </summary>
		public static Testunique Testunique(this Testfkunique obj, IDataContext db)
		{
			return db.GetTable<Testunique>().First(t => obj.Id1 == t.Id1 && obj.Id2 == t.Id2);
		}

		/// <summary>
		/// FK_testfkunique_testunique_1
		/// </summary>
		public static Testunique Testunique1(this Testfkunique obj, IDataContext db)
		{
			return db.GetTable<Testunique>().First(t => obj.Id3 == t.Id3 && obj.Id4 == t.Id4);
		}
		#endregion

		#region Testunique Associations
		/// <summary>
		/// FK_testfkunique_testunique backreference
		/// </summary>
		public static IQueryable<Testfkunique> Testfkuniques(this Testunique obj, IDataContext db)
		{
			return db.GetTable<Testfkunique>().Where(t => t.Id1 == obj.Id1 && t.Id2 == obj.Id2);
		}

		/// <summary>
		/// FK_testfkunique_testunique_1 backreference
		/// </summary>
		public static IQueryable<Testfkunique> Testfkuniques1(this Testunique obj, IDataContext db)
		{
			return db.GetTable<Testfkunique>().Where(t => t.Id3 == obj.Id3 && t.Id4 == obj.Id4);
		}
		#endregion
		#endregion
	}
}