﻿using System;
using Xamarin.Forms;

namespace Recorder.Models
{
    public class UriVideoSource : VideoSource
    {
        public static readonly BindableProperty UriProperty =
            BindableProperty.Create(nameof(Uri), typeof(string), typeof(UriVideoSource));

        public string Uri
        {
            set { SetValue(UriProperty, value); }
            get { return (string)GetValue(UriProperty); }
        }

        public UriVideoSource()
        {
        }

        public UriVideoSource(string uri)
        {
            Uri = uri;
        }
    }
}
