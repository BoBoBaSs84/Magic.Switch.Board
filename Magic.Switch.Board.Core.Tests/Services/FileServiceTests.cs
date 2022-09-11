namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class FileServiceTests : BaseTestUnit
{
	private readonly IFileService _fileService = GetService<IFileService>();
	private const string FolderPath = "D:\\UnitTest";
	private const string FileName = "UnitTest.txt";
	private const string NotExistentFileName = "NotExistentUnitTest.txt";
	private const string FileContent = "This is a unit test.";

	[TestMethod()]
	public void FileServiceNotNullTest() => Assert.IsNotNull(_fileService);

	[DataTestMethod()]
	[DataRow(FolderPath, FileName, FileContent)]
	[DataRow(FolderPath, NotExistentFileName, FileContent)]
	public void DeleteTest(string folderpath, string fileName, string fileContent)
	{
		try
		{
			_fileService.Save(folderpath, fileName, fileContent);
			_fileService.Delete(folderpath, fileName);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[DataTestMethod()]
	[DataRow(FolderPath, FileName, FileContent)]
	[DataRow(FolderPath, NotExistentFileName, FileContent)]
	public void ReadTest(string folderpath, string fileName, string fileContent)
	{
		try
		{
			_fileService.Save(folderpath, fileName, fileContent);
			string readContent = _fileService.Read(folderpath, fileName);
			Assert.AreEqual(fileContent, readContent);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[DataTestMethod()]
	[DataRow(FolderPath, FileName, FileContent)]
	[DataRow(FolderPath, NotExistentFileName, FileContent)]
	public void SaveTest(string folderpath, string fileName, string fileContent)
	{
		try
		{
			_fileService.Save(folderpath, fileName, fileContent);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}
}