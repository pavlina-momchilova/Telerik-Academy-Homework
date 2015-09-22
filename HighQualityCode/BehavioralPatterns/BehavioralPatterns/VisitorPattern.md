#Visitor Patterns

## M�������� (Motivation)
 ���������� �� ������ �����, ������ ���������� � ������� ������������� ������������. ����� ���������� �������� ������ �� �������� ������ � � ���� ������ ����� �������� ������ �� �� ���������� ����� ������ �������� �� ����������  ��� �� �� ���� �����.
 �������� ������ �� ��������� �� ���������� �������� �� ������ �� �������� ��� � �������� � �� �� �������� if ����� ��� ������ ��� 'instanceof' �� ����� �������. ���� ������ �� �� ����������, �� � ������ � �� ������� ���������� ������. � ���� ������ ������ �� �� ����� �� 'open close' �������� � �� �������� �� ���, �� ����� �� ��������  if ����� ��� ����������� ���� � ����� ��������� ���� �� ������������ ����������� �� ��������. 

## ��������� (Intent)
 * ������������ ��������, ����� ���� �� �� ������� ����� ������� �� ����� ���������.
 * Visitor �� ���������� �� ���������� ���� �������� ��� ������� �� ��������� �� ����������, ����� ����� �� �������� ����������.

## ����������� (Applicability)
 Visitor ������ � ��������� ������:
 ������� �������� ������ �� �� ���������� ����� ������ �� �������� ������ ��������� � ���������. ��� ����� �������� � ���������� ��������, ���������� �� �� �� �������. Visitor  ������� ��������� �� �������� ������� visitor concrete ���� �� ����� ��� �������� � �� ������� ���� ������������� �� �������� �� ������ ���������. ������� ��������� �� �� �������� �� �� �������, �� � ����� �������� �� ��� ���� ��������, ����� ������ �� �� �������. ������� ������� ������� visitor �� ������� ��������� � ����� ����� �� �� ������ ��� visitor �� ������ ������ ������ ����������.

## ������������� (Implementation)
 ��������������� ����� ���� ��������� ��������� � ������:
  * Visitor - ���� � ��������� ��� ���������� ���� ��������� �� ����������� �� visit ���������� �� ������ ������ �� ������ �������. ����� ����� �� ���������� � ������ � ���������� �� ������������� �� ����� ������ (signature): ������� ��� ����� ������ ��� ����� � �������.
  * Concrete Visitor - �� ����� ��� �� visitor, ������  visit ������, ����������� � ���������� visitor, ������ �� ����� ��������������. ����� visitor �� ���� ��������� �� �������� ��������. ������ ��� visitor � ��������� ������ �� ���� ������� ��� ����������� �����.
  * Visible - � ����������, ����� ��������� �������� ��������. ���� � ������ �����, ����� ��������� ����� �� ���� '�������' �� visitor ������. ����� ����� �� �������� ������ �� ������������ ���� ����������, �� �� ���� � ��������� �� ���� �������. 
  * Concrete Visible - ���� ������� ������������� Visible ��������� ��� ���� � ��������� �������� ��������. Visitor ������ � ������� ��� ���� ����� ����������� �������� ��������.
  * Object Structure - ���� � ���� �������� ������ ������, ����� ����� �� ����� ��������. ���� �������� ��������� �� ��������� ���� ������ ��������. ���� ��������� �� � ���������� ��������. ���� �� ���� ������ ���������, ���� composite �����.

## ��������� (Participants)
 * Visitor
 * Concrete Visitor
 * Visitable
 * Concrete Visitable
 * Object Structure

## ����������� (Consequences)
 * �����:
  1. ���������� �� ���� �������� � �����
  2. ���������� ��������� �� � �������������� ����� ��������� ���������� ����������� �� ������. ���� �� ���������� � visitor. ���������� ��������� �� ��������� �� ������������ � ��������� visitor ����������.
 * ������:
  1. �������� �� ��� Concrete Element ���� � ������. ����� ��� Concrete Element ������� ���� ���������� �������� �� Visitor � ������������� ������������� ��� ����� Concrete Visitor ����.
  2. Concrete Element ���������� ������ ���������� ����� �� ��������� visitors �� ������ �������� ��. ���� ���� �� �� ������� �� �������� �������� ��������, ����� ��������� ���������� ��������� �� ��������, ����� ����� �� �������������� ��������������.

## ��������� (Structure)
![alt tag](http://www.oodesign.com/images/design_patterns/behavioral/visitor_example_customers_-_uml_class_diagram.gif)