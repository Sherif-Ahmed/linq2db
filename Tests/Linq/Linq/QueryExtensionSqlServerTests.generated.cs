﻿// Generated.
//
using System;
using System.Linq;
using System.Linq.Expressions;

using LinqToDB.DataProvider.SqlServer;

using NUnit.Framework;

namespace Tests.Linq
{
	partial class QueryExtensionSqlServerTests
	{
		[Test]
		public void WithForceScanTableTest([IncludeDataSources(true, TestProvName.AllSqlServer2012Plus)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithForceScan()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (ForceScan)"));
		}

		[Test]
		public void WithForceScanInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer2012Plus)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithForceScanInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (ForceScan)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (ForceScan)"));
		}

		[Test]
		public void WithHoldLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithHoldLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (HoldLock)"));
		}

		[Test]
		public void WithHoldLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithHoldLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (HoldLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (HoldLock)"));
		}

		[Test]
		public void WithNoLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithNoLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (NoLock)"));
		}

		[Test]
		public void WithNoLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithNoLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (NoLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (NoLock)"));
		}

		[Test]
		public void WithNoWaitTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithNoWait()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (NoWait)"));
		}

		[Test]
		public void WithNoWaitInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithNoWaitInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (NoWait)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (NoWait)"));
		}

		[Test]
		public void WithPagLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithPagLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (PagLock)"));
		}

		[Test]
		public void WithPagLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithPagLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (PagLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (PagLock)"));
		}

		[Test]
		public void WithReadCommittedTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithReadCommitted()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (ReadCommitted)"));
		}

		[Test]
		public void WithReadCommittedInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithReadCommittedInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (ReadCommitted)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (ReadCommitted)"));
		}

		[Test]
		public void WithReadCommittedLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithReadCommittedLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (ReadCommittedLock)"));
		}

		[Test]
		public void WithReadCommittedLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithReadCommittedLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (ReadCommittedLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (ReadCommittedLock)"));
		}

		[Test]
		public void WithReadPastTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithReadPast()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (ReadPast)"));
		}

		[Test]
		public void WithReadPastInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithReadPastInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (ReadPast)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (ReadPast)"));
		}

		[Test]
		public void WithReadUncommittedTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithReadUncommitted()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (ReadUncommitted)"));
		}

		[Test]
		public void WithReadUncommittedInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithReadUncommittedInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (ReadUncommitted)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (ReadUncommitted)"));
		}

		[Test]
		public void WithRepeatableReadTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithRepeatableRead()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (RepeatableRead)"));
		}

		[Test]
		public void WithRepeatableReadInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithRepeatableReadInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (RepeatableRead)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (RepeatableRead)"));
		}

		[Test]
		public void WithRowLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithRowLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (RowLock)"));
		}

		[Test]
		public void WithRowLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithRowLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (RowLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (RowLock)"));
		}

		[Test]
		public void WithSerializableTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithSerializable()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (Serializable)"));
		}

		[Test]
		public void WithSerializableInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithSerializableInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (Serializable)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (Serializable)"));
		}

		[Test]
		public void WithTabLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithTabLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (TabLock)"));
		}

		[Test]
		public void WithTabLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithTabLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (TabLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (TabLock)"));
		}

		[Test]
		public void WithTabLockXTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithTabLockX()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (TabLockX)"));
		}

		[Test]
		public void WithTabLockXInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithTabLockXInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (TabLockX)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (TabLockX)"));
		}

		[Test]
		public void WithUpdLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithUpdLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (UpdLock)"));
		}

		[Test]
		public void WithUpdLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithUpdLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (UpdLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (UpdLock)"));
		}

		[Test]
		public void WithXLockTableTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
				from p in db.Parent
					.AsSqlServerSpecific()
					.WithXLock()
				select p;

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("WITH (XLock)"));
		}

		[Test]
		public void WithXLockInScopeTest([IncludeDataSources(true, TestProvName.AllSqlServer)] string context)
		{
			using var db = GetDataContext(context);

			var q =
			(
				from p in db.Parent
				join c in db.Child on p.ParentID equals c.ParentID
				select p
			)
			.AsSqlServerSpecific()
			.WithXLockInScope();

			_ = q.ToList();

			Assert.That(LastQuery, Contains.Substring("[p] WITH (XLock)"));
			Assert.That(LastQuery, Contains.Substring("[c_1] WITH (XLock)"));
		}

	}
}
