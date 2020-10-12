using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{

		//コインが見える可能性のあるz軸の最大値（課題）
		private float visiblePosZ = -10f;

		private GameObject UnityChan;

        // Use this for initialization
        void Start ()
        {
			
				UnityChan = GameObject.Find("unitychan");
			
                //回転を開始する角度を設定
                this.transform.Rotate (0, Random.Range (0, 360), 0);
        }

        // Update is called once per frame
        void Update ()
        {
                //回転
                this.transform.Rotate (0, 3, 0);
				
				Vector3 uPos = UnityChan.transform.position;
				
				Vector3 selfPos = this.transform.position;
				
				//IF文でUNITYちゃんよりマイナスになったら消す
				if( selfPos.z - visiblePosZ < uPos.z)
				{
					Destroy(this.gameObject);
				}
				
        }
}
