using PackageManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Commands.InstallCommandTests.Mocks
{
    internal class InstallCommandMocked : InstallCommand
    {
        public InstallCommandMocked(IInstaller<IPackage> installer, IPackage package) 
            : base(installer, package)
        {
        }

        public IInstaller<IPackage> Installer
        {
            get
            {
                return this.installer;
            }
        }

        public IPackage Package
        {
            get
            {
                return this.package;
            }
        }

    }
}
