using Hikanyan.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Hikanyan.Core
{
    /// <summary>
    /// A singleton that manages display state and access to UI Views 
    /// </summary>
    public class UIManager : AbstractSingleton<UIManager>
    {
        [SerializeField]
        Canvas _canvas;
        [SerializeField]
        RectTransform _root;
        [SerializeField]
        RectTransform _backgroundLayer;
        [SerializeField]
        RectTransform _viewLayer;

        List<View> _views;

        View _currentView;

        readonly Stack<View> _history = new();

        void Start()
        {
            _views = _root.GetComponentsInChildren<View>(true).ToList();
            Init();

            //_viewLayer.ResizeToSafeArea(_canvas);
        }

        void Init()
        {
            foreach (var view in _views)
                view.Hide();
            _history.Clear();
        }

        public T GetView<T>() where T : View
        {
            foreach (var view in _views)
            {
                if (view is T tView)
                {
                    return tView;
                }
            }

            return null;
        }

        public void Show<T>(bool keepInHistory = true) where T : View
        {
            foreach (var view in _views)
            {
                if (view is T)
                {
                    Show(view, keepInHistory);
                    break;
                }
            }
        }

        
        public void Show(View view, bool keepInHistory = true)
        {
            if (_currentView != null)
            {
                if (keepInHistory)
                {
                    _history.Push(_currentView);
                }

                _currentView.Hide();
            }

            view.Show();
            _currentView = view;
        }

        public void GoBack()
        {
            if (_history.Count != 0)
            {
                Show(_history.Pop(), false);
            }
        }
    }
}