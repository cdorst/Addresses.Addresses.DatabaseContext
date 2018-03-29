// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.StateCityZips.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Addresses.Addresses.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for Address entities</summary>
    public class AddressDbContext : StateCityZipDbContext
    {
        /// <summary>Constructs AddressDbContext EntityFrameworkCore database context using given options</summary>
        public AddressDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of Address entities</summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Address>().HasIndex(new Address().GetUniqueIndex()).IsUnique();
        }
    }
}
