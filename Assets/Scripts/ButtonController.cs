using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler  {

	private bool pressed;												

	public void OnPointerDown(PointerEventData eventData){				// method OnPointerDown
		pressed = true;													
	}

	public void OnPointerUp(PointerEventData eventData){				// method OnPointerUp
		pressed = false;												
	}

	public bool GetPressed(){											//method GetPressed
		return pressed;													
	}
}
