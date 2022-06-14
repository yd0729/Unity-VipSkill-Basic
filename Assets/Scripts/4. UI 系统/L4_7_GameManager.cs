using System.Collections.Generic;

public class L4_7_GameManager
{
    // 单例模式
    private static L4_7_GameManager _instance;

    public static L4_7_GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new L4_7_GameManager();
            }
            return _instance;
        }
    }

    // 用户信息
    public List<L4_7_UserInfo> userInfos = new();

    public void SaveUserInfo(L4_7_UserInfo userInfo)
    {
        userInfos.Add(userInfo);
    }

    public L4_7_UserInfo GetUserInfo(string userName)
    {
        for (int i = 0; i < userInfos.Count; i += 1)
        {
            if (userName == userInfos[i].UserName)
            {
                return userInfos[i];
            }
        }
        return null;
    }
}
