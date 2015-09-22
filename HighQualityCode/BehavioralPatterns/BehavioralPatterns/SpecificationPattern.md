#Specification Pattern

## ��������� (motivation)
 Specification patterns ���������� �� :
  * ������� �� ����� ������� �� ����������� ��������
  * ��������� �� ����� ����� ������������ 
  * ������������ �� ����������:
    1. ���������� � ���������������
    2. ��������� ������������ ����������� �� ����������
## ��������� (intent)
�� ��������� �������� ������� (and/or/not) 

## ����������� (applicability)
 * ������ ����� ������ � ������� ������ ������ (���������� ������ ������)
 * ��������� �� ������������ ������� �� ������������� ������ (���� ������� �� �������� �����)  

## �������� �������� (known uses)
 * Gamification (badges/points)
 * ��������� ��������� �� ������������
 * ������ �������

## ������������� (implementation)
 * ������� ������������� ������� �� �������������� (And, Or, Not), ����� ������������� ISpecification
 * ����� ��������� ������������ ���� ����� �� ����� �������� 

## ��������� (participants)
 * NotSpecification <TEntity>
 * AndSpecification <TEntity>
 * OrSpecification <TEntity>
 * ISpecification <TEntity>

## ��������� (structure)
![alt tag](https://upload.wikimedia.org/wikipedia/commons/8/8b/Specification_UML_v2.png)

## �������� ������ (related patterns)
 * Composite Pattern