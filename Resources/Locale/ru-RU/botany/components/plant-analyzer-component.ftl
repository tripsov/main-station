plant-analyzer-component-no-seed = Растение не обнаружено

plant-analyzer-component-health = Здоровье:
plant-analyzer-component-age = Возраст:
plant-analyzer-component-water = Вода:
plant-analyzer-component-nutrition = Питание:
plant-analyzer-component-toxins = Токсины:
plant-analyzer-component-pests = Вредители:
plant-analyzer-component-weeds = Сорняки:

plant-analyzer-component-alive = [color=green]ЖИВОЕ[/color]
plant-analyzer-component-dead = [color=red]МЕРТВОЕ[/color]
plant-analyzer-component-unviable = [color=red]НЕПРИГОДНОЕ[/color]
plant-analyzer-component-mutating = [color=#00ff5f]МУТИРУЕТ[/color]
plant-analyzer-component-kudzu = [color=red]КУДЗУ[/color]

plant-analyzer-soil = В {$holder} обнаружены химикаты: [color=white]{$chemicals}[/color]. Статус: {$count ->
    [one]не поглощен
    *[other]не поглощены
}.
plant-analyzer-soil-empty = В {$holder} отсутствуют непоглощённые химикаты.

plant-analyzer-component-environemt = Это [color=green]{$seedName}[/color] требует атмосферу с давлением [color=lightblue]{$kpa} кПа ± {$kpaTolerance} кПа[/color], температуру [color=lightsalmon]{$temp}°К ± {$tempTolerance}°К[/color] и уровень освещённости [color=white]{$lightLevel} ± {$lightTolerance}[/color].
plant-analyzer-component-environemt-void = Это [color=green]{$seedName}[/color] должно выращиваться [bolditalic]в вакууме космоса[/bolditalic] при уровне освещения [color=white]{$lightLevel} ± {$lightTolerance}[/color].
plant-analyzer-component-environemt-gas = Это [color=green]{$seedName}[/color] требует атмосферу, содержащую [bold]{$gases}[/bold] при давлении [color=lightblue]{$kpa} кПа ± {$kpaTolerance} кПа[/color], температуре [color=lightsalmon]{$temp}°К ± {$tempTolerance}°К[/color] и уровне освещённости [color=white]{$lightLevel} ± {$lightTolerance}[/color].

plant-analyzer-produce-plural = {MAKEPLURAL($thing)}

plant-analyzer-output = {$yield ->
    [0]{$gasCount ->
        [0]Единственное, что растение делает — потребляет воду и питательные вещества.
        *[other]Единственное, что растение делает — превращает воду и питательные вещества в [bold]{$gases}[/bold].
    }
    *[other]Растение имеет [color=lightgreen]{$yield} {$potency}[/color]{$seedless ->
        [true]{" "}но [color=red]без семян[/color]
        *[false]{$nothing}
    }{" "}{$yield ->
        [one]цветок
        *[other]цветков
    }{" "}которые{$gasCount ->
        [0]{$nothing}
        *[other]{$yield ->
            [one]{" "}выделяет
            *[other]{" "}выделяют
        }{" "}[bold]{$gases}[/bold] и
    }{" "}превращаются в{$yield ->
        [one]{" "}{INDEFINITE($firstProduce)} [color=#a4885c]{$produce}[/color]
        *[other]{" "}[color=#a4885c]{$producePlural}[/color]
    }.{$chemCount ->
        [0]{$nothing}
        *[other]{" "}В стебле обнаружены следы [color=white]{$chemicals}[/color].
    }
}

plant-analyzer-potency-tiny = крошечный
plant-analyzer-potency-small = маленький
plant-analyzer-potency-below-average = ниже среднего размера
plant-analyzer-potency-average = среднего размера
plant-analyzer-potency-above-average = выше среднего размера
plant-analyzer-potency-large = довольно большой
plant-analyzer-potency-huge = огромный
plant-analyzer-potency-gigantic = гигантский
plant-analyzer-potency-ludicrous = невероятно огромный
plant-analyzer-potency-immeasurable = неизмеримо огромный

plant-analyzer-print = Печать
plant-analyzer-printout-missing = Н/Д
plant-analyzer-printout = [color=#9FED58][head=2]Отчёт анализатора растений[/head][/color]{$nl
}──────────────────────────────{$nl
}[bullet/] Вид: {$seedName}{$nl
}{$indent}[bullet/] Пригодность: {$viable ->
    [no][color=red]Нет[/color]
    [yes][color=green]Да[/color]
    *[other]{LOC("plant-analyzer-printout-missing")}
}{$nl
}{$indent}[bullet/] Выносливость: {$endurance}{$nl
}{$indent}[bullet/] Продолжительность жизни: {$lifespan}{$nl
}{$indent}[bullet/] Продукт: [color=#a4885c]{$produce}[/color]{$nl
}{$indent}[bullet/] Кудзу: {$kudzu ->
    [no][color=green]Нет[/color]
    [yes][color=red]Да[/color]
    *[other]{LOC("plant-analyzer-printout-missing")}
}{$nl
}[bullet/] Профиль роста:{$nl
}{$indent}[bullet/] Вода: [color=cyan]{$water}[/color]{$nl
}{$indent}[bullet/] Питание: [color=orange]{$nutrients}[/color]{$nl
}{$indent}[bullet/] Токсины: [color=yellowgreen]{$toxins}[/color]{$nl
}{$indent}[bullet/] Вредители: [color=magenta]{$pests}[/color]{$nl
}{$indent}[bullet/] Сорняки: [color=red]{$weeds}[/color]{$nl
}[bullet/] Экологические условия:{$nl
}{$indent}[bullet/] Состав: [bold]{$gasesIn}[/bold]{$nl
}{$indent}[bullet/] Давление: [color=lightblue]{$kpa} кПа ± {$kpaTolerance} кПа[/color]{$nl
}{$indent}[bullet/] Температура: [color=lightsalmon]{$temp}°К ± {$tempTolerance}°К[/color]{$nl
}{$indent}[bullet/] Освещённость: [color=gray][bold]{$lightLevel} ± {$lightTolerance}[/bold][/color]{$nl
}[bullet/] Цветы: {$yield ->
    [-1]{LOC("plant-analyzer-printout-missing")}
    [0][color=red]0[/color]
    *[other][color=lightgreen]{$yield} {$potency}[/color]
}{$nl
}[bullet/] Семена: {$seeds ->
    [no][color=red]Нет[/color]
    [yes][color=green]Да[/color]
    *[other]{LOC("plant-analyzer-printout-missing")}
}{$nl
}[bullet/] Химикаты: [color=gray][bold]{$chemicals}[/bold][/color]{$nl
}[bullet/] Выделения: [bold]{$gasesOut}[/bold]

