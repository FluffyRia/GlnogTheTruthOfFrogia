using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Zenject;

namespace Intro {
    public class ComicManager : MonoBehaviour {
        [field: SerializeField] public List<Sprite> ComicSprites { get; private set; }
        [field: SerializeField] public Image CurrentComicSlide { get; private set; }

        [field: SerializeField] public PlayerInput PlayerInput { get; private set; }

        private uint _index = 0; 

        [Inject]
        private void InitSprites (IntroConfig config){
            ComicSprites = new List<Sprite>();

            for (int i = 0; i < config.ComicSprites.Length; i++) {
                ComicSprites.Add(config.ComicSprites[i]);
            }
            SetComicSlide(ComicSprites[(int)_index]);

            PlayerInput.actions.FindAction("Next").performed += NextSlide;
        }


        private void SetComicSlide(Sprite sprite) {
            CurrentComicSlide.sprite = sprite;
        }
        
        private void NextSlide(InputAction.CallbackContext ctx) {
            _index++;
            SetComicSlide(ComicSprites[(int)_index]);
        }
        private void PreviousSlide(InputAction.CallbackContext ctx) {
            _index--;
            SetComicSlide(ComicSprites[(int)_index]);
        }

        private void OnDestroy() {
            PlayerInput.actions.FindAction("Next").performed -= NextSlide;
        }
    }
}