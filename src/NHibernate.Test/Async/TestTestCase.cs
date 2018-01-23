﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using NUnit.Framework;

namespace NHibernate.Test
{
	using System.Threading.Tasks;
	/// <summary>
	/// Summary description for TestTestCase.
	/// </summary>
	[TestFixture]
	public class TestTestCaseAsync : TestCase
	{
		protected override IList Mappings
		{
			get { return Array.Empty<string>(); }
		}

		private bool _failOnTearDown;

		protected override void OnTearDown()
		{
			if (!_failOnTearDown)
				return;

			_failOnTearDown = false;
			throw new InvalidOperationException("Tear-down failure");
		}

		private ISession _nonClosedSession;

		[Test(Description = "This test tear-down should fail due to unclosed session. If test is successful, it has indeed failed.")]
		[Explicit("Testing test failure")]
		public async Task TearDownShouldFailDueToUncloseSessionAsync()
		{
			_nonClosedSession = OpenSession();
			using (var otherSession = OpenSession())
			{
				// Dummy code.
				await (otherSession.BeginTransaction().RollbackAsync());
			}
		}
	}
}