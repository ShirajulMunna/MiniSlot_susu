 using UnityEngine;
using UnityEngine.UI;

namespace JGM.Game.Rollers
{
    public class RollerItem : MonoBehaviour
    {
        public RollerItemType Type { get; private set; }

        [SerializeField]
        private Image _image;

        private Roller _roller;
        private float _moveSpeed;
        private float _bottomLimit;

        public float newSpeed_1 { set; get; }

     
        public void Initialize(Roller roller, RollerItemType type, Sprite sprite, float moveSpeed, float bottomLimit)
        {
            Debug.Log("Initialize");
            _roller = roller;
            Type = type;
            _image.sprite = sprite;
            _moveSpeed = moveSpeed;
            _bottomLimit = bottomLimit;
        }

        public void Spin()
        {
            
            bool isSpeedIncreased= Roller.instance.increasedSpeed;
            int timer= Roller.instance.spinTime;
            Debug.Log("rollername " + _roller.name);
            if (timer == 5)
            {
                _moveSpeed = 500;
                float itemTime_1 = 0;
                float div = 1;
                if (_roller.name == "roller_1")
                {
                    itemTime_1 = RollerManager.Instance._rollers[0].GetComponent<Roller>().totalTime;
                    div = 1;
                }
                else if (_roller.name == "roller_2")
                {
                    itemTime_1 = RollerManager.Instance._rollers[1].GetComponent<Roller>().totalTime;
                    div = 2;
                }
                else if (_roller.name == "roller_3")
                {
                    itemTime_1 = RollerManager.Instance._rollers[2].GetComponent<Roller>().totalTime;
                    div = 3;
                }


                itemTime_1 = itemTime_1 / div;
                if (itemTime_1 > 0 && itemTime_1 <= 1f)
                {
                    Debug.Log("Log_1");
                    _moveSpeed *= 3f;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 1f && itemTime_1 <= 1.75f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed *= 5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 1.75f && itemTime_1 <= 2.0f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed *= 7f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.0f && itemTime_1 <= 2.5f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += 9f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.5f && itemTime_1 <= 3.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 3.0f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 3.5f && itemTime_1 <= 4.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 6.5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.0f && itemTime_1 <= 4.50f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 8.5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.50f && itemTime_1 <= 5.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 10.0f;
                    newSpeed_1 = _moveSpeed;


                }



            }
            else if (timer == 7)
            {
                Debug.Log("In 7");
                _moveSpeed = 500;
                float itemTime_1 = 0;
                float div = 1;
                if (_roller.name == "roller_1")
                {
                    itemTime_1 = RollerManager.Instance._rollers[0].GetComponent<Roller>().totalTime;
                    div = 1;
                }
                else if (_roller.name == "roller_2")
                {
                    itemTime_1 = RollerManager.Instance._rollers[1].GetComponent<Roller>().totalTime;
                    div = 2;
                }
                else if (_roller.name == "roller_3")
                {
                    itemTime_1 = RollerManager.Instance._rollers[2].GetComponent<Roller>().totalTime;
                    div = 3;
                }


                itemTime_1 = itemTime_1 / div;
                if (itemTime_1 > 0 && itemTime_1 <= 1f)
                {
                    Debug.Log("Log_1.7");
                    _moveSpeed *= 3f;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 1f && itemTime_1 <= 1.75f)
                {
                    Debug.Log("Log_2.7");
                    _moveSpeed *= 5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 1.75f && itemTime_1 <= 2.0f)
                {
                    Debug.Log("Log_3.7");
                    _moveSpeed *= 7f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.0f && itemTime_1 <= 2.5f)
                {
                    Debug.Log("Log_4.7");

                    _moveSpeed *= 9f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.5f && itemTime_1 <= 3.00f)
                {
                    Debug.Log("Log_5.7");

                    _moveSpeed *= 11.0f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 3.5f && itemTime_1 <= 4.00f)
                {
                    Debug.Log("Log_6.7");

                    _moveSpeed *= 13f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.0f && itemTime_1 <= 4.50f)
                {
                    Debug.Log("Log_7.7");

                    _moveSpeed -= 5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.50f && itemTime_1 <= 5.00f)
                {
                    Debug.Log("Log_8.7");

                    _moveSpeed -= 7.0f;
                    newSpeed_1 = _moveSpeed;


                }
                if (itemTime_1 > 5.00f && itemTime_1 <= 5.50f)
                {
                    Debug.Log("Log_9.7");
                    _moveSpeed -= 9f;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 5.50f && itemTime_1 <= 6.00f)
                {
                    Debug.Log("Log_10.7");

                    _moveSpeed -= 11f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 6.00f && itemTime_1 <= 6.50f)
                {
                    Debug.Log("Log_11.7");

                    _moveSpeed -= 13f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 6.50f && itemTime_1 <= 7.00f)
                {
                    Debug.Log("Log_12.7");

                    _moveSpeed -= 15f;
                    newSpeed_1 = _moveSpeed;


                }



            }
            else if (timer == 10)
            {
                _moveSpeed = 500;
                float itemTime_1 = 0;
                float div = 1;
                if (_roller.name == "roller_1")
                {
                    itemTime_1 = RollerManager.Instance._rollers[0].GetComponent<Roller>().totalTime;
                    div = 1;
                }
                else if (_roller.name == "roller_2")
                {
                    itemTime_1 = RollerManager.Instance._rollers[1].GetComponent<Roller>().totalTime;
                    div = 2;
                }
                else if (_roller.name == "roller_3")
                {
                    itemTime_1 = RollerManager.Instance._rollers[2].GetComponent<Roller>().totalTime;
                    div = 3;
                }


                itemTime_1 = itemTime_1 / div;
                if (itemTime_1 > 0 && itemTime_1 <= 1f)
                {
                    Debug.Log("Log_1");
                    _moveSpeed *= 3f;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 1f && itemTime_1 <= 1.75f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed *= 5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 1.75f && itemTime_1 <= 2.0f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed *= 7f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.0f && itemTime_1 <= 2.5f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += 9f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.5f && itemTime_1 <= 3.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 3.0f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 3.5f && itemTime_1 <= 4.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 6.5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.0f && itemTime_1 <= 4.50f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 8.5f;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.50f && itemTime_1 <= 5.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed -= 10.0f;
                    newSpeed_1 = _moveSpeed;


                }


            }
          
           
            transform.localPosition -= _moveSpeed * Time.deltaTime * Vector3.up;
            
            if (transform.localPosition.y < _bottomLimit)
            {
                transform.localPosition = _roller.GetLastItemLocalPosition() + _roller.GetSpacingBetweenItems();
                _roller.MoveFirstItemToTheBack();
            }
          
        }

        public void setImage(Sprite image)
        {
            _image.sprite = image;
        }

        public void setType(RollerItemType type)
        {
            Type = type;
        }

    }
}