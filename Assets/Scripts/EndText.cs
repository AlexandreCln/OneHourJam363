using TMPro;
using UnityEngine;

namespace OneHourJam363
{
    public class EndText : MonoBehaviour
    {
        public TMP_Text text;

        private void Start()
        {
            text.text = $"You went in collision with {Stats.Instance.count} ladybugs";
        }
    }
}
