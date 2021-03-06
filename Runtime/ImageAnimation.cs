using UnityEngine.UI;
using UnityEngine;

namespace Game.Animation
{
    [RequireComponent(typeof(Image))]
    public class ImageAnimation : AnimationBase
    {
        private Image _image;
        private void Awake()
        {
            _image = GetComponent<Image>();
        }
        protected override void Render(int frame)
        {
            _image.sprite = _data.FrameArray[frame];
        }
    }
}