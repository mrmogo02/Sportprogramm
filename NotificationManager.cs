using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android

public class NotificationManager : MonoBehaviour
{
    void Start()
    {
        CreateNotificationChannel();
    }

    public void CreateNotificationChannel()
    {
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id";
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications"
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    public void SendNotification()
    {
        var notification = new AndroidNotification();
        notification.Title = "Вам повестка";
        notification.Text = "Вы обязаны явится"
        notification.FireTime = System.DateTime.Now.Addhours(24);
        
        AndroidNotificayionCenter.SendNotificayion(notification, "channel_id")
    }
}
