﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GolemsWindows {
	/// <summary>
	/// Interaction logic for LobbyWindow.xaml
	/// </summary>
	public partial class LobbyWindow : Window {
		GolemsGame.GameParameters gameParameter;

		public LobbyWindow() {
			InitializeComponent();

			gameParameter = new GolemsGame.GameParameters();
		}

		public bool IsClosed { get; private set; }
		protected override void OnClosed(EventArgs e) {
			base.OnClosed(e);
			IsClosed = true;
		}

		private void Window_Closed(object sender, EventArgs e) {
			WindowsManager.CloseAll();
		}

		private void Back_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.MenuWindow);
		}

		private void Button_StartGame(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.GameWindow);
		}
	}
}
