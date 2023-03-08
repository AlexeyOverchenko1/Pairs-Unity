# Pairs-Unity

Папки Cards и CardsPrefabs содержат примеры спрайтов для проекта.
Папка Scenes содержит примеры использования скриптов на разное количество появляющихся карт.
Папка Scripts содержит скрипты для проекта.

Card
Назначение скрипта: инициализация только что созданной карты, открытие, закрытие и уничтожение карты.

CountCards
Контроль количества одновременно открытых карт, и проверка на то, одинаковы ли они. Если они одинаковы, то карты уничтожаются, иначе - закрываются.

CardSpawner
Создание карт. Задаётся количество карт и расстояние между ними. Расстояние масштабируется вместе с камерой. Объект, на котором располагается скрипт должен находиться в 
левом верхнем углу экрана (или области, в которой необходимо разместить карты).

ChooseCard
Вспомогательный скрипт для инициализации карт. Позволяет определять ID для карт, который может быть уникальным или же выбираться случайно.
