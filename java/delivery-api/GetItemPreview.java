// DocSection: delivery_api_get_item_preview
// Tip: Find more about Java/JavaRx SDKs at https://developer.kenticocloud.com/docs/javaandroid
import com.kenticocloud.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3", "<YOUR_PREVIEW_API_KEY>");

ContentItem item = client.getItem("on_roasts").item;
// EndDocSection