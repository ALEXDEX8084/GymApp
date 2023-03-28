# Программа GymsApp реализует функционал:
Using SQLite
* __Используемые классы__

1.Страницы
StepOnePage.xaml

```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.StepOnePage"  BackgroundColor="#7abdff">
    
    <VerticalStackLayout>
        <Label 
            Text="Step 1/5"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Large" Margin="0,90,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="What is your purpose?"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Small" Margin="0,50,0,50" TextColor="{StaticResource Key=textColor1}"/>
        <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
            <Button  x:Name="weightloss"
                ImageSource="icon1.png"
                     Text="Weight loss"
                Clicked="weightloss_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
            </Button>
        </Border>
        <VerticalStackLayout Margin="0,25,0,0">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                <Button  x:Name="Keepingfit"
                ImageSource="icon2.png"
                     Text="Keeping fit"
                Clicked="weightloss_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
            </Button>
        </Border>
        </VerticalStackLayout>
        <VerticalStackLayout Margin="0,25,0,0">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
            <Button  x:Name="Buildmuscle"
                ImageSource="icon3.png"
                     Text="Build muscle"
                Clicked="weightloss_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
            </Button>
        </Border>
        </VerticalStackLayout>
    </VerticalStackLayout>
</ContentPage>
```
2.StepTwoPage.xaml
```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.StepTwoPage" BackgroundColor="#7abdff">
    <VerticalStackLayout>
        <Label 
            Text="Step 2/5"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Large" Margin="0,90,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="What is your gender?"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Small" Margin="0,50,0,50" TextColor="{StaticResource Key=textColor1}"/>
        <HorizontalStackLayout VerticalOptions="Center" HorizontalOptions="Center">
            <VerticalStackLayout>
                <Border Stroke="gray" StrokeThickness="2" StrokeShape="Ellipse" WidthRequest="100" HeightRequest="100" HorizontalOptions="Center">
                    <Button  x:Name="Female"
                                             ImageSource="icon4.png"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="100" HeightRequest="100">
                    </Button>
                </Border>
                <Label Text="Female" VerticalOptions="Center" FontSize="Small"  TextColor="{StaticResource Key=textColor1}"
            HorizontalOptions="Center" Margin="0,30,0,50"/>
            </VerticalStackLayout>
            <VerticalStackLayout Margin="100,0,0,0">
                <Border Stroke="gray" StrokeThickness="2" StrokeShape="Ellipse" WidthRequest="100" HeightRequest="100" HorizontalOptions="Center">
                    <Button  x:Name="male"
                                             ImageSource="icon5.png"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="100" HeightRequest="100">
                    </Button>
                </Border>
                <Label Text="Male" VerticalOptions="Center" FontSize="Small"  TextColor="{StaticResource Key=textColor1}"
            HorizontalOptions="Center" Margin="0,30,0,50"/>
            </VerticalStackLayout>
        </HorizontalStackLayout>
        <VerticalStackLayout Margin="0,25,0,0">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                <Button  x:Name="Next"
                     Text="Next"
                Clicked="weightloss_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                </Button>
            </Border>
        </VerticalStackLayout>
    </VerticalStackLayout>
</ContentPage>
```


![Лого TexTerra](/imag1.bmp "Шаг 1")
![Лого TexTerra](/imag2.bmp "Шаг 2")