using UnityEngine;
using UnityEngine.EventSystems;

public class Dropleft : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public RectTransform togglelewd;
	public bool isOpen;
	
	// Use this for initialization
	void Start ()
	{
		togglelewd = transform.Find("ToggleLewd").GetComponent<RectTransform>();
		isOpen = false;
	}
	
	// Update is called once per frame
	void Update ()
	{

		Vector3 scale = togglelewd.localScale;
		scale.x = Mathf.Lerp(scale.x, isOpen ? 1 : 0, Time.deltaTime * 12);
		togglelewd.localScale = scale;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		isOpen = true;
	}

		public void OnPointerExit(PointerEventData eventData)
	{
		isOpen = false;
	}
}
