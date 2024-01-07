
class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.exam1 = 74
        self.exam2 = 80

register = RegisterCourse()

print("İsim : ", register.name)
print("Soyisim : ", register.surname)
print("Exam 1 : ", register.exam1)
print("Exam 2 :", register.exam2)




İsim : Ahmet
Soyisim : Kaleli
Exam 1 : 74
Exam 2 : 80

register.exam1 = 50
register.exam2 = 60

İsim: Ahmet
Soyisim :  Kaleli
Exam 1 :  50
Exam 2 : 60


class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.__exam1 = 74
        self.__exam2 = 80

register = RegisterCourse()
print("İsim : ", register.name)
print("Soyisim : ", register.surname)
print("Exam 1 : ", register.exam1)
print("Exam 2 :", register.exam2)
Şu şekilde bir hata aldık değil mi?


class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.__exam1 = 74
        self.__exam2 = 80
        self.courses = []
    def add(self, course):
        self.courses.append(course)

register = RegisterCourse()

register.add("Database Managment")
print("İsim : ", register.name)
print("Soyisim : ", register.surname)
print(register.courses)

class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.__exam1 = 74
        self.__exam2 = 80
        self.courses = []

    def __add(self, course):
        self.courses.append(course)

register = RegisterCourse()

register.add("Database Managment")



class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.__exam1 = 74
        self.__exam2 = 80
        self.__courses = []

    def __add(self, course):
        self.courses.append(course)

    def getExam1(self):
        return self.__exam1

register = RegisterCourse()

print("İsim : ", register.name)
print("Soyisim : ", register.surname)
print("Exam 1 : ", register.getExam1())

İsim : Ahmet
Soyisim : Kaleli
Exam 1 : 4
class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.__exam1 = 74
        self.__exam2 = 80
        self.__courses = []

    def __add(self, course):
        self.courses.append(course)

    def getExam1(self):
        return self.__exam1

    def setExam1(self, newVal):
        self.__exam1 = newVal


register = RegisterCourse()

print("İsim : ", register.name)
print("Soyisim : ", register.surname)
print("Exam 1 : ", register.getExam1())
Hemen çıktıya bakalım;

İsim: Ahmet
Soyisim : Kaleli
Exam 1 : 74

register.setExam1(40)

İsim: Ahmet
Soyisim : Kaleli
Exam 1 : 40


def setExam(self, newVal):
    if newVal < 0 or newVal> 100 :

class RegisterCourse :
    def __init__(self):
        self.name = "Ahmet"
        self.surname = "Kaleli"
        self.__exam1 = 74
        self.__exam2 = 80
        self.__courses = []

    def __add(self, course):
        self.courses.append(course)

    def getExam(self):
        return self.__exam1

    def setExam(self, newVal):
        if newVal < 0 or newVal> 100 :


register = RegisterCourse()
register.setExam(-10)

