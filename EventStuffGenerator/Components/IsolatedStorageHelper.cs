using System.Deployment.Application;
using System.IO;
using System.IO.IsolatedStorage;

namespace EventStuffGenerator.Components
{
    /// <summary>
    /// 격리된 저장소의 파일 입출력을 지원한다.
    /// 클릭원스로 배포된 애플리케이션에서는 애플리케이션별 격리를, 그렇지 않다면 사용자별 / 애플리케이션별 격리를 사용한다.
    /// </summary>
    public class IsolatedStorageHelper : StorageHelper
    {
        #region singleton

        private static IsolatedStorageHelper _instance;

        public static IsolatedStorageHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IsolatedStorageHelper();
                return _instance;
            }
        }

        private IsolatedStorageHelper()
        {
        }

        #endregion

        protected override dynamic GetStorage()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                return IsolatedStorageFile.GetUserStoreForApplication();
            else
                return IsolatedStorageFile.GetUserStoreForAssembly();
        }

        protected override Stream GetStream(string fileName, FileMode fileMode)
        {
            return new IsolatedStorageFileStream(fileName, fileMode, GetStorage());
        }
    }
}