using UnityEngine;
public class PlayerManager : MonoBehaviour
{
    /** 이 클래스의 싱글톤 객체 */
    static PlayerManager current = null;

    /** 객체를 생성하기 위한 GameObject */
    static GameObject container = null;

    /** 전역 변수 **/
    public class playerData
    {
        public int ID;

        public playerData(int ID)
        {
			this.ID = ID;
        }
    }

    public string playerID = "playerID";

    /** 싱글톤 객체 만들기 */
    public static PlayerManager Instance
    {
        get
        {
            if (current == null)
            {
                container = new GameObject();
                container.name = "PlayerManager";
                current = container.AddComponent(typeof(PlayerManager)) as PlayerManager;
            }
            return current;
        }
    }

	void Start( )
	{
		DontDestroyOnLoad(gameObject);
	}
}