# Generated by Django 5.1.3 on 2024-11-19 11:41

from django.db import migrations, models


class Migration(migrations.Migration):
    dependencies = [
        ("app", "0001_initial"),
    ]

    operations = [
        migrations.AddField(
            model_name="product",
            name="image",
            field=models.ImageField(null=True, upload_to=""),
        ),
    ]
