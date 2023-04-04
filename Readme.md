# Программа GymsApp реализует функционал:
* __Переходы на страницу__
* __Выбор__
* __Регистрацию__
* __Добавление собственной программы занятий__

1.Страницы
HomeGymPage.xaml

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.HomeGymPage"
             BackgroundColor="#7abdff">
    <VerticalStackLayout>
        <Image Source="fitnesslogopng.png" WidthRequest="200" HeightRequest="200" Margin="0,0,0,0"/>
        <Label 
            Text="Home"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Header" Margin="0,-40,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="Gym"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Header" Margin="0,10,0,20" TextColor="{StaticResource Key=textColor1}"/>

        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="350" HeightRequest="50" HorizontalOptions="Center">
                <Entry Placeholder = "Ivanov" BackgroundColor="White" TextColor="Gray"/>
            </Border>
        </VerticalStackLayout>

        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="350" HeightRequest="50" HorizontalOptions="Center">
                <Entry Placeholder = "*****" BackgroundColor="White" TextColor="Gray" />
            </Border>
        </VerticalStackLayout>
        <VerticalStackLayout Margin="0,25,0,0">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                <Button  x:Name="Next"
                     Text="Sign in"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                </Button>
            </Border>
        </VerticalStackLayout>
        <Button  x:Name="Next1"
                     Opacity="0"
                HorizontalOptions="Center" TextColor="White" WidthRequest="170" HeightRequest="50" BackgroundColor="{StaticResource Key=textColor}">
        </Button>
        <Label TextDecorations="Underline" HorizontalOptions="Center" Text="Sign in" Margin="0,-40,0,0" TextColor="White"/>
        <Button  x:Name="Next2"
                     Opacity="0"
                HorizontalOptions="Center" TextColor="White" WidthRequest="170" HeightRequest="50" BackgroundColor="{StaticResource Key=textColor}">
        </Button>
        <Label TextDecorations="Underline" HorizontalOptions="Center" Text="Skip" Margin="0,0,0,0" TextColor="White"/>
    </VerticalStackLayout>
</ContentPage>
```
2.StepFivePage.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.StepFivePage"
             BackgroundColor="#7abdff">

    <VerticalStackLayout>
        <Label 
            Text="Step 5/5"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Large" Margin="0,90,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="What’s your height and weight?"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Small" Margin="0,50,0,50" TextColor="{StaticResource Key=textColor1}"/>
        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="350" HeightRequest="50" HorizontalOptions="Center">
                <Entry Placeholder = "Height" BackgroundColor="White" TextColor="Gray"/>
            </Border>
        </VerticalStackLayout>

        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="350" HeightRequest="50" HorizontalOptions="Center">
                <Entry Placeholder = "Weight" BackgroundColor="White" TextColor="Gray" />
            </Border>
        </VerticalStackLayout>
        <VerticalStackLayout Margin="0,25,0,0">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                <Button  x:Name="Next"
                     Text="Next"
                Clicked="Next_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                </Button>
            </Border>
        </VerticalStackLayout>
    </VerticalStackLayout>
</ContentPage>
```
3.StepFourPage.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.StepFourPage"
            BackgroundColor="#7abdff">
    <VerticalStackLayout>
        <Label 
            Text="Step 4/5"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Large" Margin="0,90,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="How often do you exercise?"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Small" Margin="0,50,0,50" TextColor="{StaticResource Key=textColor1}"/>
        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="70" HorizontalOptions="Center">
                <Button  x:Name="Newbie"
                         Clicked="Newbie_Clicked"
                     Text="Newbie"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="70">
                </Button>
            </Border>
            <Label Text="Just getting started" VerticalOptions="Center" 
            HorizontalOptions="Center" Margin="3,-30,0,0" TextColor="{StaticResource Key=textColor}"/>
        </VerticalStackLayout>

        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="70" HorizontalOptions="Center">
                <Button x:Name="KeepOn"
                     Text="Keep on"
                    Clicked="KeepOn_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="70">
                </Button>
            </Border>
            <Label Text="1-2 times a week" VerticalOptions="Center" 
            HorizontalOptions="Center" Margin="3,-30,0,0" TextColor="{StaticResource Key=textColor}"/>
        </VerticalStackLayout>
        <VerticalStackLayout Margin="20">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="70" HorizontalOptions="Center">
                <Button x:Name="Advanced"
                     Text="Advanced"
                  Clicked="Advanced_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="70">
                </Button>
            </Border>
            <Label Text="More than 3 times a week" VerticalOptions="Center" 
            HorizontalOptions="Center" Margin="3,-30,0,0" TextColor="{StaticResource Key=textColor}"/>
        </VerticalStackLayout>
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
4.StepOnePage.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
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
                Clicked="Keepingfit_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                    
            </Button>
        </Border>
        </VerticalStackLayout>
        <VerticalStackLayout Margin="0,25,0,0">
            <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
            <Button  x:Name="Buildmuscle"
                ImageSource="icon3.png"
                     Text="Build muscle"
                Clicked="Buildmuscle_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
            </Button>
        </Border>
        </VerticalStackLayout>
    </VerticalStackLayout>
</ContentPage>
```
5.StepThreePage.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.StepThreePage" BackgroundColor="#7abdff">
    <VerticalStackLayout>
        <Label 
            Text="Step 3/5"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Large" Margin="0,90,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="What do you want to work on?"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Small" Margin="0,50,0,50" TextColor="{StaticResource Key=textColor1}"/>
        <HorizontalStackLayout HorizontalOptions="Center" VerticalOptions="Center">
            <VerticalStackLayout>
                <HorizontalStackLayout>
                    <VerticalStackLayout Margin="100,75,0,0">
                        <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" >
                            <Button x:Name="Hands"
                     Text="Hands" Clicked="Hands_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                            </Button>
                        </Border>
                    </VerticalStackLayout>
                </HorizontalStackLayout>
                <VerticalStackLayout Margin="100,25,0,0">
                    <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                        <Button  x:Name="Spine" 
                     Text="Spine" Clicked="Spine_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                        </Button>
                    </Border>
                </VerticalStackLayout>
                <VerticalStackLayout Margin="100,25,0,0">
                    <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                        <Button  x:Name="Torso"
                     Text="Torso" Clicked="Torso_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                        </Button>
                    </Border>
                </VerticalStackLayout>
                <VerticalStackLayout Margin="100,25,0,0">
                    <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                        <Button  
                            x:Name="Legs"
                     Text="Legs" Clicked="Legs_Clicked"
                 
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                        </Button>
                    </Border>
                </VerticalStackLayout>
            </VerticalStackLayout>
            <VerticalStackLayout>
                <Image Source="dlyakalkul.png" WidthRequest="400" HeightRequest="450" Margin="50,0,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="-50,-365,0,0"/>
                <Line WidthRequest="260" HeightRequest="2" BackgroundColor="White" Margin="-300,-5,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="-11,35,0,0"/>
                <Line WidthRequest="230" HeightRequest="2" BackgroundColor="White" Margin="-240,35,0,0"/>
                <Line WidthRequest="2" HeightRequest="39" BackgroundColor="White" Margin="-10,-38,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="30,50,0,0"/>
                <Line WidthRequest="255" HeightRequest="2" BackgroundColor="White" Margin="-230,-5,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="-40,70,0,0"/>
                <Line WidthRequest="210" HeightRequest="2" BackgroundColor="White" Margin="-250,-5,0,0"/>
            </VerticalStackLayout>
        </HorizontalStackLayout>
    </VerticalStackLayout>
</ContentPage>
```
6.StepTwoPage.xaml
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
                             Clicked="Female_Clicked"
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
                             Clicked="male_Clicked"
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
7.StepThreePageMale.xaml
```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GymApp.Pages.StepThreePageMale"
             BackgroundColor="#7abdff">
    <VerticalStackLayout>
        <Label 
            Text="Step 3/5"
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Large" Margin="0,90,0,0" TextColor="{StaticResource Key=textColor1}"/>
        <Label 
            Text="What do you want to work on?" 
            VerticalOptions="Center" 
            HorizontalOptions="Center" FontSize="Small" Margin="0,50,0,50" TextColor="{StaticResource Key=textColor1}"/>
        <HorizontalStackLayout HorizontalOptions="Center" VerticalOptions="Center">
            <VerticalStackLayout>
                <HorizontalStackLayout>
                    <VerticalStackLayout Margin="100,75,0,0">
                        <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" >
                            <Button x:Name="Next"
                                    Clicked="Next_Clicked"
                     Text="Hands"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                            </Button>
                        </Border>
                    </VerticalStackLayout>
                </HorizontalStackLayout>
                <VerticalStackLayout Margin="100,25,0,0">
                    <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                        <Button  
                     Text="Spine"                                     Clicked="Next_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                        </Button>
                    </Border>
                </VerticalStackLayout>
                <VerticalStackLayout Margin="100,25,0,0">
                    <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                        <Button  
                     Text="Torso"                                     Clicked="Next_Clicked"
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                        </Button>
                    </Border>
                </VerticalStackLayout>
                <VerticalStackLayout Margin="100,25,0,0">
                    <Border Stroke="gray" StrokeThickness="2" StrokeShape="RoundRectangle 20" WidthRequest="170" HeightRequest="50" HorizontalOptions="Center">
                        <Button  
                     Text="Legs"                                     Clicked="Next_Clicked"
                 
                HorizontalOptions="Center" TextColor="{StaticResource Key=textColor}" WidthRequest="170" HeightRequest="50">
                        </Button>
                    </Border>
                </VerticalStackLayout>
            </VerticalStackLayout>
            <VerticalStackLayout>
                <Image Source="silhouette1.png" WidthRequest="400" HeightRequest="450" Margin="50,0,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="-50,-365,0,0"/>
                <Line WidthRequest="260" HeightRequest="2" BackgroundColor="White" Margin="-300,-5,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="-11,35,0,0"/>
                <Line WidthRequest="230" HeightRequest="2" BackgroundColor="White" Margin="-240,35,0,0"/>
                <Line WidthRequest="2" HeightRequest="39" BackgroundColor="White" Margin="-10,-38,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="30,50,0,0"/>
                <Line WidthRequest="255" HeightRequest="2" BackgroundColor="White" Margin="-230,-5,0,0"/>
                <Rectangle WidthRequest="10" HeightRequest="10" BackgroundColor="White" RadiusX="15" RadiusY="15" Margin="-40,70,0,0"/>
                <Line WidthRequest="210" HeightRequest="2" BackgroundColor="White" Margin="-250,-5,0,0"/>
            </VerticalStackLayout>
        </HorizontalStackLayout>
    </VerticalStackLayout>
</ContentPage>
```
* __Классы__
2.Классы

* __HomeGymPage.xaml__
![Лого TexTerra](/imag1.bmp "Шаг 1")
![Лого TexTerra](/imag2.bmp "Шаг 2")
![Лого TexTerra](/imag.png "Шаг 3")
![Лого TexTerra](/imag3.png "Шаг 4 мужской")
![Лого TexTerra](/imag7.png "Шаг 4 женский")
![Лого TexTerra](/imag5.png "Шаг 5")
![Лого TexTerra](/imag6.png "Домашняя")