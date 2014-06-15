﻿using System;
using UnityEngine;
using System.Collections.Generic;

public class DragState
{

		public override string ToString ()
	{
				return string.Format ("{0},{1},{2},{3}" ,this._connecting,this._dragging,this._mousepos,this._selection);
	}

		public Boolean _connecting{ get; set; }
		public Boolean _dragging{ get; set; }
		public Vector2 _mousepos{ get; set; }
		public List<NodeSimple> _selection{ get; set; }


		public DragState (Boolean connecting, Boolean dragging, Vector2 mousepos,List<NodeSimple> selection)
		{
				_dragging = dragging;
				_mousepos = mousepos;
				_connecting = connecting;
				_selection = selection;
		}
}

