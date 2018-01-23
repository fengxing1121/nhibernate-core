﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Linq;
using NHibernate.Mapping.ByCode;
using NUnit.Framework;

namespace NHibernate.Test.Linq
{
	using System.Threading.Tasks;
	using System.Threading;
	[TestFixture]
	public class CharEqualityTestsAsync : TestCaseMappingByCode
	{
		protected override HbmMapping GetMappings()
		{
			var mapper = new ModelMapper();
			mapper.Class<Person>(ca =>
			{
				ca.Id(x => x.Id, map => map.Generator(Generators.Assigned));
				ca.Property(x => x.Name, map => map.Length(150));
				ca.Property(x => x.Type, map => map.Length(1));
			});

			return mapper.CompileMappingForAllExplicitlyAddedEntities();
		}

		protected override void OnSetUp()
		{
			using (ISession session = OpenSession())
			using (var transaction = session.BeginTransaction())
			{
				session.Save(new Person { Id = 1000, Name = "Person Type A", Type = 'A' });
				session.Save(new Person { Id = 1001, Name = "Person Type B", Type = 'B' });
				session.Save(new Person { Id = 1002, Name = "Person Type C", Type = 'C' });
				transaction.Commit();
			}
		}

		[Test]
		public async Task CharPropertyEqualToCharLiteralAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type == 'C')));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type C"));
		}

		[Test]
		public async Task CharLiteralEqualToCharPropertyAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => 'C' == x.Type)));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type C"));
		}

		[Test]
		public async Task CharPropertyEqualToCharVariableAsync()
		{
			char value = 'C';
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type == value)));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type C"));
		}

		[Test]
		public async Task CharVariableEqualToCharPropertyAsync()
		{
			char value = 'C';
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => value == x.Type)));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type C"));
		}

		[Test]
		public async Task CharPropertyNotEqualToCharLiteralAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type != 'C')));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type A", "Person Type B" }));
		}

		[Test]
		public async Task CharLiteralNotEqualToCharPropertyAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => 'C' != x.Type)));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type A", "Person Type B" }));
		}

		[Test]
		public async Task CharPropertyNotEqualToCharVariableAsync()
		{
			char value = 'C';
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type != value)));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type A", "Person Type B" }));
		}

		[Test]
		public async Task CharVariableNotEqualToCharPropertyAsync()
		{
			char value = 'C';
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => value != x.Type)));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type A", "Person Type B" }));
		}

		[Test]
		public async Task CharPropertyGreaterThanCharLiteralAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type > 'B')));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type C"));
		}

		[Test]
		public async Task CharLiteralLessThanCharPropertyAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => 'B' < x.Type)));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type C"));
		}

		[Test]
		public async Task CharPropertyGreaterThanOrEqualToCharLiteralAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type >= 'B')));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type B", "Person Type C" }));
		}

		[Test]
		public async Task CharLiteralLessThanOrEqualToCharPropertyAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => 'B' <= x.Type)));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type B", "Person Type C" }));
		}

		[Test]
		public async Task CharPropertyLessThanCharLiteralAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type < 'B')));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type A"));
		}

		[Test]
		public async Task CharLiteralGreaterThanCharPropertyAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => 'B' > x.Type)));
			Assert.That(results.Count, Is.EqualTo(1));
			Assert.That(results[0].Name, Is.EqualTo("Person Type A"));
		}

		[Test]
		public async Task CharPropertyLessThanOrEqualToCharLiteralAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => x.Type <= 'B')));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type A", "Person Type B" }));
		}

		[Test]
		public async Task CharLiteralGreaterThanOrEqualToCharPropertyAsync()
		{
			var results = await (ExecuteAsync(session => session.Query<Person>().Where(x => 'B' >= x.Type)));
			Assert.That(results.Count, Is.EqualTo(2));
			Assert.That(results.Select(p => p.Name), Is.EquivalentTo(new[] { "Person Type A", "Person Type B" }));
		}

		protected override void OnTearDown()
		{
			using (ISession session = OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				session.Delete("from Person");
				transaction.Commit();
			}
		}

		private async Task<IList<Person>> ExecuteAsync(Func<IStatelessSession, IQueryable<Person>> query, CancellationToken cancellationToken = default(CancellationToken))
		{
			using (var session = Sfi.OpenStatelessSession())
			using (session.BeginTransaction())
			{
				return await (query(session).ToListAsync(cancellationToken));
			}
		}
	}
}