using Xunit;
using JARF.Definitions.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARF.Definitions.Connection.Tests
{
    public class JarfSQLConnection_Tests
    {
        [Fact()]
        public void Create_Test()
        {
            JarfSQLConnection.Create("");
            Assert.True(JarfSQLConnection.Instance != null, "Connection instance is null");
        }

        [Fact]
        public void Initialize_Test()
        {
            Assert.True(JarfSQLConnection.Instance != null, "Connection instance is null");
        }

        [Fact()]
        public void Open_Test()
        {

        }

        [Fact()]
        public void OpenAsync_Test()
        {

        }

        [Fact()]
        public void OpenAsync_Test1()
        {

        }
    }
}