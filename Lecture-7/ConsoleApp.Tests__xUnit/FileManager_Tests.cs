using ConsoleApp.Services;
using Newtonsoft.Json;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests__xUnit
{
    public class FileManager_Tests
    {
        FileManager fileManager;
        string content;

        public FileManager_Tests()
        {
            // arrange
            fileManager = new FileManager();
            fileManager.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
            content = JsonConvert.SerializeObject(new { FirstName = "Hans", LastName = "Mattin-Lassei" });
        }

        [Fact]
        public void Should_Create_a_File_With_Json_Content()
        {
            // act
            fileManager.Save(content);
            string result = fileManager.Read();

            // assert
            Assert.True(File.Exists(fileManager.FilePath));
            Assert.Equal(result.Trim(), content);
        }
    }
}
