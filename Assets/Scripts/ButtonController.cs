using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler  {

	private bool pressed;												// boolean arvo "pressed"

	public void OnPointerDown(PointerEventData eventData){				// methodi OnPointerDown
		pressed = true;													// pressed = tosi
	}

	public void OnPointerUp(PointerEventData eventData){				// methodi OnPointerUp
		pressed = false;												// pressed = epätosi
	}

	public bool GetPressed(){											// bool GetPressed
		return pressed;													// palaa takaisin bool pressed
	}
}
